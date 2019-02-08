using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Help_Board.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public IList<Question> Questions { get; set; }
        public IList<Reply> Replies { get; set; }
        public IList<Question> SubscribedThreads { get; set; }
    }
}
