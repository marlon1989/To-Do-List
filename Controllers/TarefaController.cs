using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using To_Do_List.Context;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class TarefaController : Controller
    {
        private readonly Context.OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if(ModelState.IsValid)
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(tarefa);
        }
    }
}