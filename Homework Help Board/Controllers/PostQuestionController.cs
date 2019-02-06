using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Homework_Help_Board.Models;

namespace Homework_Help_Board.Controllers
{
	public class PostQuestionController : Controller
	{
        //private IRepository repository;

        public IActionResult PostQuestion()
        {
            return View();
        }

        //public ViewResult Index() => View(repository.Questions);

        //public ViewResult Create() => View();

        /*[HttpPost]
        public IActionResult Create(Question question)
        {
            repository.AddQuestion(question);
            return RedirectToAction("Index");
        }*/
	}
}
