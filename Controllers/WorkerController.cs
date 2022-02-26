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
    public class WorkerController : ControllerBase
    {
        private readonly IDbService _service;
        public WorkerController(IDbService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("getWorker")]
        public async Task<IActionResult> GetWorker(int idWorker)
        {
            try
            {
                var worker = await _service.GetWorker(idWorker);
                return Ok(worker);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getWorkers")]
        public async Task<IActionResult> GetWorkers()
        {
            try 
            {
                var workers = await _service.GetAllWorkers();
                return Ok(workers);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("addWorker")]
        public async Task<IActionResult> CreateWorker([FromBody] Worker worker)
        {
            try
            {
                var newWorker = await _service.AddWorker(worker);
                return Ok(newWorker);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("updateWorker")]
        public async Task<IActionResult> UpdateWorkerData([FromBody] Worker worker)
        {
            try
            {
                var updatedWorker = await _service.UpdateWorker(worker);
                return Ok(updatedWorker);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("disableWorker")]
        public async Task<IActionResult> DisableWorker(int idWorker)
        {
            try
            {
                await _service.DisableWorker(idWorker);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("deleteWorker")]
        public async Task<IActionResult> DeleteWorker(int idWorker)
        {
            try
            {
                await _service.DeleteWorker(idWorker);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
