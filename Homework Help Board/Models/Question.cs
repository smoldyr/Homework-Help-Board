using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Help_Board.Models
{
    public class Question
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public DateTime DateCreated { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int NumFlags { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
    }
}
