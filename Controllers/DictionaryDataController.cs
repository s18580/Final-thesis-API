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
         * 5. Add code for all of the regions
         */

        private readonly IDbService _service;
        public DictionaryDataController(IDbService service)
        {
            _service = service;
        }

        #region Worksite
        [HttpGet]
        [Route("getWorksites")]
        public async Task<IActionResult> GetWorksites()
        {
            try
            {
                var worksites = await _service.GetAllWorksites();
                return Ok(worksites);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        #endregion

        #region Role
        #endregion

        #region Role Assignment
        #endregion

        #region Supply Item Type
        #endregion

        #region Order Item Type
        #endregion

        #region Delivery Type
        #endregion

        #region File Status
        #endregion

        #region File Type
        #endregion

        #region Order Status
        #endregion

        #region Binding Type
        #endregion

        #region Minimum Rate
        #endregion

        #region Service Name
        #endregion

        #region Price List
        #endregion
    }
}
