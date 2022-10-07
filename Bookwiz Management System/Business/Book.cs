using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookwiz_Management_System.Business
{
    public class Book
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public int Unit_Price { get; set; }

        public int publishingYear { get; set; }

        public int Quantity { get; set; }
        public int authorID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string mail { get; set; }

    }
}
