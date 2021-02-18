using DevEventsAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEventsAPI.Controllers
{
    [Route("api/usuarios")]
    public class UsuariosControllers : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario Usuario)
        {
            return Ok();
        }
    }
}
