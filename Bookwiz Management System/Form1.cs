using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookwiz_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (comboBoxLogin.Text == "MIS Manager" && textBoxPasword.Text=="Henry")
            {
                MIsManager obj = new MIsManager();
                obj.Show();
            }
            else if(comboBoxLogin.Text =="Sales Manager" && textBoxPasword.Text == "Thomas")
            {
                SalesManager obj = new SalesManager();
                obj.Show();
            }
            else if (comboBoxLogin.Text == "Inventory Controller" && textBoxPasword.Text == "Peter")
            {
                InventoryController obj = new InventoryController();
                obj.Show();
            }
            else if (comboBoxLogin.Text == "Order Clerk" && textBoxPasword.Text == "Mary" || textBoxPasword.Text == "Jennifer")
            {
                OrderClerk obj = new OrderClerk();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You have entered a wrong credentials,Please select right position and type password");

                textBoxPasword.Clear();
                textBoxPasword.Focus();
            }

        }
    }
}
