using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Homework_Help_Board.Models

{
    public class BrowseQuestionsViewModel
    {

        public User User { get; set; }
        public List<ReplyViewModel> Replies { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
        public bool ShowQuestions { get; set; }
        public bool ShowReplies { get; set; }
        public bool ShowSubscribes { get; set; }
        public int ClickedReplyID { get; set; }
        public bool ClickedUpvote { get; set; }

    }

   
    public class ReplyViewModel
    {
        public Reply Reply { get; set; }
        public bool UpVote { get; set; }
    }

    public class QuestionViewModel
    {
        public Question Question { get; set; }

        public bool Open { get; set; }
        public bool Subscribe { get; set; }
    }
}
