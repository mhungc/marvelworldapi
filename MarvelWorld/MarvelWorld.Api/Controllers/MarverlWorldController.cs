using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarvelWorld.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarverlWorldController : ControllerBase
    {
        private readonly ILogger<MarverlWorldController> _logger;

        public MarverlWorldController(ILogger<MarverlWorldController> logger)
        {
            _logger = logger;
        }

        // GET: api/MarverlWorld
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return new object[] {
                new {
                        name = "Spider Man",
                        thumbnail = new {
                                            path = "sd",
                                            extension = "dfsd"
                                        }
                   },
                new {
                        name = "Spider Man 22",
                        thumbnail = new {
                                            path = "sd2",
                                            extension = "dfsd2"
                                        }
                   }
            };
        }

        // GET: api/MarverlWorld/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MarverlWorld
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MarverlWorld/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
