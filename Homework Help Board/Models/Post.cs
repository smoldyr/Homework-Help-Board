using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Help_Board.Models
{
    interface IPost<P>
    {
        int PostID { get; set; }
        int UserID { get; set; }
        DateTime DateCreated { get; set; }
        string Body { get; set; }
        int NumFlags { get; set; }

    }
}
