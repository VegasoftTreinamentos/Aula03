using Csystems.Aula02.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Csystems.Aula02.Web.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {
            var model = new List<Cliente> {
                new Cliente { Id = 1, Nome = "Diego", CPF = "0000000000" },
                new Cliente { Id = 2, Nome = "Denner", CPF = "512343154" },
                new Cliente { Id = 3, Nome = "Donizetti", CPF = "511224154" }
            };       
            return View(model);
        }

        public ActionResult Detalhes()
        {
            var model = new Cliente { Id = 1, Nome = "Diego", CPF = "0000000000" };
            
            return View(model);
        }

    }
}