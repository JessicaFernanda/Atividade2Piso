using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoComercioPISO.WebSite.Controllers
{
    
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }
       
        //[Route("~/redirecionar")]
        //public ActionResult Redirecionar()
        //{
            //return Redirect("~/");
            //return RedirectToRoute("~/");
        //    return RedirectToAction("Index");
        //}

        //AJAX- é um comando javascript (jquery) - faz um requisição ao servidor e returna um bloco de código sem atualiza toda página
        //[Route("~/partial")]
        //public ActionResult Partial()
        //{
        //    return PartialView("_LoginPartial");
        //}

        //[Authorize]
        [Route("~/sobre")]
        public ActionResult About()
        {
            ViewBag.Message = "Esta é a descrição da minha aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Minha página de contato.";

            ViewData.Add(new KeyValuePair<string, object>("Mensagem", "Mensagem via viewData"));

            return View();
        }
    }
}