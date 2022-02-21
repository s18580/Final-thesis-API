using Final_thesis_api.Models;
using Final_thesis_api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            var worker = await _service.GetWorker(idWorker);
            return Ok(worker);
        }

        [HttpGet]
        [Route("getWorkers")]
        public async Task<IActionResult> GetWorkers()
        {
            var workers = await _service.GetAllWorkers();
            return Ok(workers);
        }

        [HttpPost]
        [Route("addWorker")]
        public async Task<IActionResult> CreateWorker([FromBody] Worker worker)
        {
            var newWorker = await _service.AddWorker(worker);
            return Ok(newWorker);
        }

        [HttpPost]
        [Route("updateWorker")]
        public async Task<IActionResult> UpdateWorkerData([FromBody] Worker worker)
        {
            var updatedWorker = await _service.UpdateWorker(worker);
            return Ok(updatedWorker);
        }

        [HttpPost]
        [Route("disableWorker")]
        public async Task<IActionResult> DisableWorker(int idWorker)
        {
            if(await _service.DisableWorker(idWorker))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("deleteWorker")]
        public async Task<IActionResult> DeleteWorker(int idWorker)
        {
            if (await _service.DeleteWorker(idWorker))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
