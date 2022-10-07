using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.Business;

namespace Bookwiz_Management_System.Validator
{
    public class ValidatorOrder
    {
    
        public static bool IsValidID(TextBox text)
        {
            int tempID;
            if ((text.TextLength != 3) || !((Int32.TryParse(text.Text, out tempID))))
            {
                MessageBox.Show(" Entered Invalid Order ID,Order ID must have 3 digits!!");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;

        }
        public static bool IsvalidQty(int qty)
        {
            Boolean flag = true;
            if ((qty <= 1))
            {
                MessageBox.Show("You have entred a invalid quantity of books,It must have at least one");
                flag = false;

            }
            return flag;
        }
        

        
        public static bool IsValidID(string input)
        {

            int tempID;
            if ((input.Length != 3) || (Int32.TryParse(input, out tempID)))
            {
                MessageBox.Show("Entered Invalid order ID, order ID must have 3 digits!!");
                return false;
            }
            return true;

        }
        public static bool IsValidName(TextBox text)
        {
            for (int i = 0; i < text.TextLength; i++)
            {
                if (char.IsDigit(text.Text, i) || (char.IsWhiteSpace(text.Text, i)))
                {
                    MessageBox.Show("Invalid Name...,Please enter the valid book name.", "INVALID NAME");
                    text.Clear();
                    text.Focus();
                    return false;
                }

            }
            return true;

        }
        public static bool IsUniqueID(List<OrderBook> list1, int id)
        {
            foreach (OrderBook odr in list1)
            {
                if (odr.orderId == id)
                {
                    MessageBox.Show("Duplicate order id,Please enter a unique order id");
                    return false;
                }
            }
            return true;
        }
    }
}

