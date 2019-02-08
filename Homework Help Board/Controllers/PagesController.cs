using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework_Help_Board.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Help_Board.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult HomeFeed()
        {
            return View();
        }

        public IActionResult AccountManagement()
        {
            return View();
        }

        public IActionResult BrowseQuestion()
        {
            return View();
        }

        public IActionResult PostQuestion()
        {
            return View();
        }

        public IActionResult QuestionDetail()
        {
            return View();
        }

        public IActionResult CreateQuestion()
        {
            return View();
        }
        
        public IActionResult CreateQuestion(Question question)
        {
            if (ModelState.IsValid)
            {
                //add code to save question to database
            }

            return View(question);
        }
    }
}