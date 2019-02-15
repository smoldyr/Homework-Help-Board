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
            return View("Login");
        }

        public IActionResult HomeFeed (bool? recentQA, bool? recentreplies /* bool? recentpost*/)
        {
            var model = new HomeFeedVM();

            model.User = new User
            {
                UserID = 1,

            };

            model.User.Questions = new List<Question>();

            model.User.Questions.Add(new Question
            {
                PostID = 1,
            });

            model.User.Replies = new List<Reply>();

            model.User.Replies.Add(new Reply
            {
                PostID = 2,
            });

            

            model.Replies = new List<RecentReplyVM>();
            foreach (var r in model.User.Replies)
            {
                model.Replies.Add(new RecentReplyVM { Reply = r });
            }

            model.Questions = new List<RecentQuestionVM>();
            foreach (var q in model.User.Questions)
            { model.Questions.Add(new RecentQuestionVM { Question = q });
            }

           
            //model.PostID = new List<RecentPostVM>();
            //foreach (var q in model.PostID)
            //{
            //    model.Questions.Add(new RecentPostVM { post = p });
            //}


            if (recentQA != null)
            {
                if ((bool)recentQA)
                {
                    // if user clicked the recent QA button
                    model.RecentQuestions = true;
                }
            }

            if (recentreplies != null)
            {
                if ((bool)recentreplies)
                {
                    // if user clicked the recent replies button
                    model.RecentReplies = true;
                }
            }

            //if (recentpost != null)
            //{
            //    if ((bool)recentpost)
            //    {

                    
            //        // if user clicked the recent posts button
            //        model.RecentPosts = true;




                    if (ModelState.IsValid)
                    {

                        RedirectToAction("HomeFeed");
                    }

                    return View(model);

            //    }
            //}
        }


        public IActionResult AccountManagement()
        {
            return View("AccountManagement");
        }


        public IActionResult BrowseQuestions(bool? showquestions, bool? showreplies, bool? showsubscribes)
        {
            var model = new BrowseQuestionsViewModel();

            model.User = new User
            {
                 UserID = 1,
                 

            };

            model.User.Questions = new List<Question>();

            model.User.Questions.Add(new Question
            {

                PostID = 1,
            });

            model.User.Replies = new List<Reply>();

            model.User.Replies.Add(new Reply
            {
                PostID = 2,

            });

            model.Replies = new List<ReplyViewModel>();
            foreach(var r in model.User.Replies)
            {
                model.Replies.Add(new ReplyViewModel { Reply = r });
            }

            if(showquestions != null)
            {
                if ((bool)showquestions)
                {
                    // if user clicked the questions button
                    model.ShowQuestions = true;
                }
            }

            if (showreplies != null)
            {
                if ((bool)showreplies)
                {
                    // if user clicked the replies button
                    model.ShowReplies = true;
                }
            }

            if (showsubscribes != null)
            {
                if ((bool)showsubscribes)
                {
                    // if user clicked the subscribes button
                    model.ShowSubscribes = true;
                }
            }

            if (ModelState.IsValid)
            {

                RedirectToAction("BrowseQuestions");
            }


            return View(model); 
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

        [HttpPost]
        public IActionResult Vote(BrowseQuestionsViewModel model)
        {
            var clickedReply = model.Replies.First(r => r.Reply.PostID == model.ClickedReplyID);

            //model.ClickedUpvote

            return PartialView("_UpvotePartialView", clickedReply.Reply);
        }
    }
}