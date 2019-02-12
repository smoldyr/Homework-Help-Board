﻿using System;
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
            return View("Login");
        }

        public IActionResult HomeFeed(Question question)
        {
            if (ModelState.IsValid)
            {

                RedirectToAction("HomeFeed");
            }

            return View(question);
        }

        public IActionResult AccountManagement()
        {
            return View("AccountManagement");
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
        
        public IActionResult CreateQuestion(Question question)
        {
            if (ModelState.IsValid)
            {
                //add code to save question to database

                RedirectToAction("QuestionDetail");
            }

            return View("QuestionDetail", question);
        }

        public IActionResult CreateReply(Reply reply)
        {
            if (ModelState.IsValid)
            {
                //add code to save question to database

                RedirectToAction("QuestionDetail");
            }

            return View("QuestionDetail", reply);
        }
    }
}