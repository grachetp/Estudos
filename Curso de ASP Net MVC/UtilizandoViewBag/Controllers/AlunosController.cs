using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilizandoViewBag.Models;

namespace UtilizandoViewBag.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos
        private List<Aluno> alunos = new List<Aluno>(new[]
        {
            new Aluno(1, "Joao Carlos", "joao@email.com"),
            new Aluno(2, "Maria das Dores", "maria@email.com"),
            new Aluno(3, "Jose Pereira", "jose@email.com"),
            new Aluno(4, "Pedro Augusto", "pedro@email.com"),
            new Aluno(5, "Carla Andrade", "carla@email.com")
        });

        public ActionResult Index()
        {
            //String
            ViewBag.Mensagem1 = "Atencao! Faltam 3 dias para o fechamento do semestre.";

            //Objeto complexo
            ViewBag.Mensagem2 = new Notificacao(1, "Atencao! Faltam 3 dias para o fechamento do semestre.");

            //Enviando o model para a view
            return View(alunos);
        }
    }
}