using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.Business;

namespace Bookwiz_Management_System.Validator
{
    public class ValidatorBook
    {
        public static bool IsValidID(TextBox text)
        {
            int tempID;
            if ((text.TextLength != 5) || !((Int32.TryParse(text.Text, out tempID))))
            {
                MessageBox.Show(" Entered Invalid Author ID,Author ID must have 5 digits!!");
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
        public static bool IsvalidYear(int year)
        {
            Boolean flag = true;
            if (1950 < year && year >= 2022)
            {
                MessageBox.Show("You have entred a invalid publishing year of a book");
                flag = false;

            }
            return flag;
        }

        public static bool IsvalidUnitPrice(int p)
        {
            Boolean flag = true;
            if ((p <= 1))
            {
                MessageBox.Show("You have entred a invalid price of a book");
                flag = false;

            }
            return flag;
        }
        public static bool IsValidID(string input)
        {

            int tempID;
            if ((input.Length != 5) || (Int32.TryParse(input, out tempID)))
            {
                MessageBox.Show("Entered Invalid Author ID, Author ID must have 5 digits!!");
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
                    MessageBox.Show("Invalid Name...,Please enter the valid Author name.", "INVALID NAME");
                    text.Clear();
                    text.Focus();
                    return false;
                }

            }
            return true;

        }
        public static bool IsUniqueID(List<Book> list1, int id)
        {
            foreach (Book bk  in list1)
            {
                if (bk.authorID == id)
                {
                    MessageBox.Show("Please enter a unique author id");
                    return false;
                }
            }
            return true;
        }
    }
}
