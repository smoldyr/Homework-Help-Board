using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Help_Board.Models
{
    public class Reply : IPost<Reply>
    {
        public int PostID { get; set; } //from IPost
        public int UserID { get; set; } //from IPost
        public DateTime DateCreated { get; set; } //from IPost
        public string Body { get; set; } //from IPost
        public int NumVotes { get; set; }
        public int NumFlags { get; set; } //from IPost
    }
}
