using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework_Help_Board.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



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

        public IActionResult BrowseQuestions(Question question)
        {

            if (ModelState.IsValid)
            {

                RedirectToAction("BrowseQuestions");
            }


            return View(question); 
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

                RedirectToAction("QuestionDetail");
            }

            return View(question);
        }

        public IActionResult CreateReply()
        {
            return View();
        }

        public IActionResult CreateReply(Reply reply)
        {
            if (ModelState.IsValid)
            {
                //add code to save question to database

                RedirectToAction("QuestionDetail");
            }

            return View(reply);
        }
    }
}