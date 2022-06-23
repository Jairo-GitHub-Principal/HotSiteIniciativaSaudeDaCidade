using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
           Interesse interesseId = new Interesse();

           
            if(cad.Nome == null){
                ViewBag.msg = "o campo nome não foi preenchido";
                               
            } else{
                if(cad.Email == null){
                      ViewBag.msg = "o campo E-mail não foi preenchido";
                
                }else{
                    
                    interesseId.Id = dbs.CadastraInteresse(cad);

                       
                    if(interesseId.Id > 0){
                    ViewBag.msg = "cadastro realizado com sucesso";
                
                    }else{
                       ViewBag.msg = "falha no cadastro, tente mais tarde";
                    }
                }
            }
            return View("Index",cad);
        }

    }
}
