using Final_thesis_api.Models;
using Final_thesis_api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Final_thesis_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryDataController : ControllerBase
    {
        /* To Improve Section
         * 1. Change types of errors in catch statments.
         * 2. Add data validation ?
         * 3. Add authorization/authentication
         * 4. Add comments for db methods
         */

        private readonly IDbService _service;
        public DictionaryDataController(IDbService service)
        {
            _service = service;
        }
    }
}
