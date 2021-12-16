using Final_thesis_api.Models.DictionaryModels;
using Final_thesis_api.Models.DTOs;
using Final_thesis_api.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Final_thesis_api.Handlers
{
    public class SimpleJwtAuthenticationHandler
    {
        private readonly IConfiguration _configuration;
        private readonly IDbService _service;
        public SimpleJwtAuthenticationHandler(IConfiguration configuration, IDbService service)
        {
            _configuration = configuration;
            _service = service;
        }

        public string HashPassword(string password)
        {
            // generate salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // create passwordHash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // store salt with hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // transform bytes into string
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        public async Task<Object> AuthorizeUser(UserLogin userLogin)
        {
            var userData = await _service.GetUserLoginData(userLogin.Email);
            if (!ComparePasswords(userLogin, userData))
            {
                throw new UnauthorizedAccessException();
            }

            var token = await CreateJwtToken(userData);
            
            return new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                refreshToken = Guid.NewGuid(),
            };
        }

        private bool ComparePasswords(UserLogin userlogin, UserData userData)
        {
            // get salt from hash
            byte[] hashBytes = Convert.FromBase64String(userData.PasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // hash the password
            var pbkdf2 = new Rfc2898DeriveBytes(userlogin.Password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // compare passwords
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }

        private async Task<JwtSecurityToken> CreateJwtToken(UserData userData)
        {
            //   get all user roles
            List<Role> roles = (List<Role>)await _service.GetAllUserRoles(userData.IdWorker);

            //   create claims, key and credensials
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, "1"));
            roles.ForEach(n => {
                claims.Add(new Claim(ClaimTypes.Role, n.Name));
            });

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecretValidationKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            //   create token
            var token = new JwtSecurityToken
            (
                issuer: _configuration["JwtValidIssuer"],
                audience: _configuration["JwtValidIssuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials
            );

            return token;
        }
    }
}
