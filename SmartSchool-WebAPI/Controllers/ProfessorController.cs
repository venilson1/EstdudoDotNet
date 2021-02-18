using System;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            try
            {
                return Ok("Vih");
            }
            catch(Exception e)
            {
                return BadRequest($"erro{e}");
            }
        }
    }
}