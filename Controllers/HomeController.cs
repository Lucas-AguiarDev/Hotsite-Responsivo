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
            try
            {
                InteresseService dbs = new InteresseService();
                dbs.CadastraInteresse(cad);

                return Json(new {status = "OK"});
            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao conectar com Banco de Dados" + e.Message);

                return Json(new {status = "ERR", mensagem = "Falha no banco de dados!"});
            }

        }

    }
}
