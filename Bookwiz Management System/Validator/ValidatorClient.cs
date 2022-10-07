using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.Business;

namespace Bookwiz_Management_System.Validator
{
    public class ValidatorClient
    {
   
        
        public static bool IsValidName(TextBox text)
        {
            for (int i = 0; i < text.TextLength; i++)
            {
                if (char.IsDigit(text.Text, i) || (char.IsWhiteSpace(text.Text, i)))
                {
                    MessageBox.Show("Invalid Name...,Please enter the valid Client name.", "INVALID NAME");
                    text.Clear();
                    text.Focus();
                    return false;
                }

            }
            return true;

        }

        public static bool EnoughCreditLimit(int text)
        {

            Boolean flag = true;
            if ((text   <=   999) )
            {
                MessageBox.Show("You don't have enough credit limit, client must have at least $1000 credit limit!!");
                flag = false;
            }
            return flag;
        }
        
    }
}


