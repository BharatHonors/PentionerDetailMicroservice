using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PentionerDetailMicroservice.Model;
using PentionerDetailMicroservice.Repository;
using Microsoft.AspNetCore.Authorization;
using System.Text.Encodings;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PentionerDetailMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PentionerDetailController : ControllerBase
    {
        private IPentionerDetailsRepo _repo;

        public PentionerDetailController(IPentionerDetailsRepo pentionerDetails)
        {
            _repo = pentionerDetails;
        }
        ///Getting the details of the pensioner details from csv file by giving Aadhar Number
        ///Summary
        /// <returns> pensioner Values</returns>

        // GET: api/PensionerDetail/5
        [HttpGet("{aadhar}")]
        
        public IActionResult PensionerDetailByAadhar(string aadhar)
        {
            var  pensioner = _repo.PensionerDetailByAadhar(aadhar);
            return Ok(pensioner);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult PensionerDetails()
        {
            var pensioner = _repo.PentionerDetails();
            return Ok(pensioner);
        }

    }
}
