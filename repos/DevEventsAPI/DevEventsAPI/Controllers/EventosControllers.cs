using DevEventsAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEventsAPI.Controllers
{
    [Route("api/eventos")]
    public class EventosControllers : ControllerBase 
    {
        [HttpGet]
        public IActionResult ListarEventos()
        {
            Evento evento = new Evento
            {
               Titulo = "Bootcamp",
               Descricao = "Um Super Evento",
               DataInicio = new DateTime(2021, 01, 29),
               DataFim = new DateTime(2021, 02, 01)
            };

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterEvento(int Id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Evento evento)//espera receber dados via corpo da requisição
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int Id, [FromBody] Evento evento) 
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Cancelar(int Id)
        {
            return NoContent();
        }

        //api/eventos/1/usuarios/3/inscrever
        [HttpPost("{id}/usuarios/{idUsuario}/inscrever")]
        public IActionResult Inscrever(int id, int idUsuario, [FromBody] Inscricao inscricao)
        {
            return NoContent();
        }
        
        
    }
}
//ControllerBase retorna as respostas http