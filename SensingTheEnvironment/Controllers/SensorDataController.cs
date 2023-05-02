using Microsoft.AspNetCore.Mvc;
using SensingTheEnvironment.Models;
using SensingTheEnvironment.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensingTheEnvironment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorDataController : ControllerBase
    {

        private SensorDataRepository _repository;

        public SensorDataController(SensorDataRepository repository)
        {
            _repository = repository;
        }



        // GET: api/<SensorDataController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<SensorData>> Get()
        {
            List<SensorData> data = _repository.GetAll();
            if (data.Count < 1)
            {
                return NoContent();
            }
            return Ok(data);
        }

        // GET api/<SensorDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SensorDataController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<SensorData> Post([FromBody] SensorData newReading)
        {
            try
            {
                SensorData data = _repository.Add(newReading);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<SensorDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SensorDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
