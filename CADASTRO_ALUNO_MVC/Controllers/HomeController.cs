using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CADASTRO_ALUNO_MVC.Models;

namespace CADASTRO_ALUNO_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public List<Aluno> lista= new List<Aluno>();
        public IActionResult Index()
        {
            lista = ListaAluno.ListarALunos(); 
            return View(lista);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Aluno aluno)
        {
            ListaAluno.IncluirAluno(aluno);
            lista=ListaAluno.ListarALunos();
            return View("Index", lista);
        }
    }
}
