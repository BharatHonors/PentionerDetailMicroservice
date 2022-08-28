using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Text.Encodings;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PentionerDetailMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PentionerDetailController : ControllerBase
    {
        // GET: api/<PentionerDetailController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PentionerDetailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PentionerDetailController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PentionerDetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PentionerDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
