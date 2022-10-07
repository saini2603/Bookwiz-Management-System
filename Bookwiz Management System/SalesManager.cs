using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.DataLayer;
using Bookwiz_Management_System.Business;
using Bookwiz_Management_System.Validator;

namespace Bookwiz_Management_System
{
    public partial class SalesManager : Form
    {
        public SalesManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxChoiceUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceClient.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelInfoClient.Text = "Please enter the First Name";
                    textBoxInputClient.Focus();
                    break;
                case 1:
                    labelInfoClient.Text = "Please enter the Last Name";
                    textBoxInputClient.Focus();
                    break;
                
                default:
                    break;
            }
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceClient.SelectedIndex;
            switch (choice)
            {
                case -1:
                    MessageBox.Show("Please select the search option");
                    break;
                case 0:
                    client clt = clientIO.Search(textBoxInputClient.Text);
                    if (clt != null)
                    {
                        
                        textBoxClientFirstName.Text = clt.FirstName;
                        textBoxClientLastName.Text = clt.LastName;
                        textBoxCreditlimit.Text = Convert.ToString(clt.creditLimit);
                        textBoxCity.Text = clt.city;
                        textBoxPostalCode.Text = clt.postalCode;
                        textBoxstreet.Text = clt.street;
                        maskedTextBoxClientFax.Text = clt.faxNumber;
                        maskedTextBoxClientPhone.Text = clt.phoneNumber;
                    }

                    else
                    {
                        MessageBox.Show("Client data not Found!");
                        textBoxInputClient.Clear();
                        textBoxInputClient.Focus();
                    }
                    break;
                case 1:
                    client clt1 = clientIO.Search(textBoxInputClient.Text);
                    if (clt1 != null)
                    {

                        textBoxClientFirstName.Text = clt1.FirstName;
                        textBoxClientLastName.Text = clt1.LastName;
                        textBoxCreditlimit.Text = Convert.ToString(clt1.creditLimit);
                        textBoxCity.Text = clt1.city;
                        textBoxPostalCode.Text = clt1.postalCode;
                        textBoxstreet.Text = clt1.street;
                        maskedTextBoxClientFax.Text = clt1.faxNumber;
                        maskedTextBoxClientPhone.Text = clt1.phoneNumber;
                    }

                    else
                    {
                        MessageBox.Show("client data not Found!");
                        textBoxInputClient.Clear();
                        textBoxInputClient.Focus();
                    }
                    
                    break;
                default:
                    break;
            }
        }

        private void textBoxInputUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelInfoUser_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            clientIO.ListClients(listViewClient);
        }
        private void ClearAll()
        {
            textBoxClientFirstName.Clear();
            textBoxClientLastName.Clear();
            textBoxCreditlimit.Clear();
           maskedTextBoxClientFax.Clear();
           maskedTextBoxClientPhone.Clear();
           textBoxstreet.Clear();
            textBoxPostalCode.Clear();
            textBoxCity.Clear();

        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            List<client> list2 = clientIO.Listclients();
            if ((ValidatorClient.IsValidName(textBoxClientFirstName)) && (ValidatorEmployee.IsValidName(textBoxClientLastName)) && ValidatorClient.EnoughCreditLimit(Convert.ToInt32(textBoxCreditlimit.Text)))


            {

                client clt=new client();

                clt.FirstName = textBoxClientFirstName.Text;
                clt.LastName = textBoxClientLastName.Text;
                clt.creditLimit = Convert.ToInt32(textBoxCreditlimit.Text);
                clt.faxNumber = maskedTextBoxClientFax.Text;
                clt.phoneNumber = maskedTextBoxClientPhone.Text;
                clt.street = textBoxstreet.Text;
                clt.postalCode = textBoxPostalCode.Text;
                clt.city = textBoxCity.Text;
                clientIO.Add(clt);
                ClearAll();

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
