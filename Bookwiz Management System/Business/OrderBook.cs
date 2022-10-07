using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookwiz_Management_System.Business
{
    public class OrderBook
    {
        public int orderId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
         
        public string phoneNumber { get; set; }

        public string bookName { get; set; }

        public int quantity { get; set; }

        public int payableAmount { get; set; }

    }
}
