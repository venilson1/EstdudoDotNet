using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class PaginasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Paginas = new Pagina().Lista(); 
            //a ViewBag.Paginas recebe os dados da Business que recebe do DataBase
            //que envia para a camada views
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public void Criar()
        {
            DateTime data;
            DateTime.TryParse(Request["time"], out data);
            var pagina = new Pagina();
            pagina.Nome = Request["nome"];
            pagina.Conteudo = Request["conteudo"];
            pagina.Time = data;
            pagina.Save();
            Response.Redirect("/paginas");
        }


    }
}