using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Help_Board.Models
{
    public class Question : IPost<Question>
    {
        public int PostID { get; set; } //from IPost
        public int UserID { get; set; } //from IPost
        public DateTime DateCreated { get; set; } //from IPost
        public string Title { get; set; }
        public string Subject { get; set; }
        public int Grade { get; set; }
        public string Body { get; set; } //from IPost
        public IList<Reply> Responses { get; set; }
        public int NumFlags { get; set; } //from IPost
    }
}
