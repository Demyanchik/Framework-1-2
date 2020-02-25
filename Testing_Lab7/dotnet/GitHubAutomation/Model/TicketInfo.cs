using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_1_2.Model
{
    class TicketInfo
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TicketInfo(string title, string firstname, string lastname)
        {
            Title = title;
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
