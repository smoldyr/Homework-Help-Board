using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Homework_Help_Board.Models

{
    public class HomeFeedVM
    {



        public User User { get; set; }
        public IList PostID {get; set;}


        public List<RecentReplyVM> Replies { get; set; }
        public List<RecentQuestionVM> Questions { get; set; }
        public List <RecentPostVM> Posts {get; set;}

        public bool RecentQuestions { get; set; }
        public bool RecentReplies { get; set; }
        public bool RecentPosts { get; set; }

        public int ClickedReplyID { get; set; }
        public bool ClickedUpvote { get; set; }
    }

    public class RecentPostVM
    {
        public Reply Reply { get; set; }
        public Question question { get; set; }
        public bool UpVote { get; set; }
    }


    public class RecentReplyVM
    {
        public Reply Reply { get; set; }
        public bool UpVote { get; set; }
    }

    public class RecentQuestionVM
    {
        public Question Question { get; set; }
        public bool Open { get; set; }
        public bool Subscribe { get; set; }
    }
}

    


