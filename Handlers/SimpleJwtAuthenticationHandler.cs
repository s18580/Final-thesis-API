using Final_thesis_api.Models.DictionaryModels;
using Final_thesis_api.Models.DTOs;
using Final_thesis_api.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Object> AuthorizeUser(UserLogin userLogin)
        {
            var userData = await _service.GetUserLoginData(userLogin.Email);
            if (!comparePasswords(userLogin, userData))
            {
                throw new InvalidCredentialException();
            }

            var token = await createJwtToken(userData);
            
            return new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                refreshToken = Guid.NewGuid(),
            };
        }

        private bool comparePasswords(UserLogin userlogin, UserData userData)
        {
            // hash the password
            // compare passes
            return true;
        }

        private async Task<JwtSecurityToken> createJwtToken(UserData userData)
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
