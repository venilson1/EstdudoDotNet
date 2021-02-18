using DevEventsAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEventsAPI.Controllers
{
    [Route("api/categorias")]
    public class CategoriasControllers : ControllerBase
    {
        [HttpGet]
        public IActionResult ListarTodas()
        {
            var categorias = new List<Categoria>
            {
               new Categoria { Descricao = ".NET"},
               new Categoria { Descricao = "C#"},
               new Categoria { Descricao = "TypeScript"}
            };
            return Ok(categorias);
        }
    }
}
