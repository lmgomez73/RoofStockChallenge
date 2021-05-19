using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoofstockChallenge.Model.DTO;
using RoofstockChallenge.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoofstockChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;
        private readonly IPropertyService _service;

        // GET: api/<PropertyController>
        public PropertyController(ILogger<PropertyController> logger, IPropertyService service)
        {
            _logger = logger;
            _service = service;
        }
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
             nameof(DefaultApiConventions.Get))]
        public async Task<IEnumerable<PropertyDTO>> Get()
        {
            return _service.GetProperties();
        }

        // GET api/<PropertyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PropertyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PropertyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PropertyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
