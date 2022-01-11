using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TodoApi.Models;
using TodoApi.Models.RepositoryInterface;

// -----------------------------------------------------------------------------------------------------
// This is the base controller to use without the Repository pattern, will use if the pattern is bad
// -----------------------------------------------------------------------------------------------------
namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {   
        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
