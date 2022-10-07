using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.Business;

namespace Bookwiz_Management_System.Validator
{
    public class ValidatorEmployee
    { 

        public static bool IsValidID(TextBox text)
        {
            int tempID;
            if ((text.TextLength != 5) || !((Int32.TryParse(text.Text, out tempID))))
            {
                MessageBox.Show(" Entered Invalid Employee ID,Employee ID must have 5 digits!!");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;

        }
        public static bool IsValidID(string input)
        {

            int tempID;
            if ((input.Length != 5) || (Int32.TryParse(input, out tempID)))
            {
                MessageBox.Show("Entered Invalid Employee ID, Employee ID must have 5 digits!!");
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
                    MessageBox.Show("Invalid Name...,Please enter the valid Employee name.", "INVALID NAME");
                    text.Clear();
                    text.Focus();
                    return false;
                }

            }
            return true;

        }
        public static bool IsUniqueID(List<Employee> list1, int id)
        {
            foreach (Employee emp in list1)
            {
                if (emp.EmployeeId == id)
                {
                    MessageBox.Show("Please enter a unique employee id");
                    return false;
                }
            }
            return true;
        }
    }
}

