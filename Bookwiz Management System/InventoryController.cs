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
    public partial class InventoryController : Form
    {
        public InventoryController()
        {
            InitializeComponent();
        }

        private void InventoryController_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            List<Book> list2 = BookIO.Listbooks();
            if ((ValidatorBook.IsValidName(textBoxAuthorFirstName))
                && (ValidatorBook.IsvalidQty(Convert.ToInt32(textBoxQty.Text)))
                && (ValidatorBook.IsvalidUnitPrice(Convert.ToInt32(textBoxPrice.Text)))
                && (ValidatorBook.IsValidName(textBoxAuthorLastName))
                && (ValidatorBook.IsUniqueID(list2, Convert.ToInt32(textBoxAuthorID.Text)))
                &&(ValidatorBook.IsvalidYear(Convert.ToInt32(textBoxYearPublished.Text))))
            { 

                Book bk = new Book();

                bk.authorID = Convert.ToInt32(textBoxAuthorID.Text);
                bk.firstName = textBoxAuthorFirstName.Text;
                bk.lastName = textBoxAuthorLastName.Text;
                bk.mail = textBoxAuthorEmail.Text;
                bk.ISBN = textBoxISBN.Text;
                bk.Title = textBoxBookTitle.Text;
                bk.Unit_Price = Convert.ToInt32(textBoxPrice.Text);
                bk.Quantity = Convert.ToInt32(textBoxQty.Text);
                bk.publishingYear = Convert.ToInt32(textBoxYearPublished.Text);

                BookIO.Add(bk);
                ClearAll();

            }

        }
        private void ClearAll()
        {
            textBoxAuthorID.Clear();
            textBoxAuthorFirstName.Clear();
            textBoxAuthorLastName.Clear();
            textBoxAuthorEmail.Clear();
            textBoxISBN.Clear();
            textBoxBookTitle.Clear();
            textBoxPrice.Clear();
            textBoxQty.Clear();
            textBoxYearPublished.Clear();

        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceBook.SelectedIndex;
            switch (choice)
            {
                case -1:
                    MessageBox.Show("Please select the search option");
                    break;
                case 0:
                    Book bk = BookIO.Search(textBoxInputBook.Text);
                    if (bk != null)
                    {
                       
                        textBoxAuthorID.Text = Convert.ToString(bk.authorID);
                        textBoxAuthorFirstName.Text = bk.firstName ;
                         textBoxAuthorLastName.Text= bk.lastName ;
                         textBoxAuthorEmail.Text=bk.mail ;
                         textBoxISBN.Text = bk.ISBN ;
                         textBoxBookTitle.Text= bk.Title ;
                         textBoxPrice.Text= Convert.ToString(bk.Unit_Price) ;
                        textBoxQty.Text = Convert.ToString(bk.Quantity);
                        textBoxYearPublished.Text = Convert.ToString(bk.publishingYear);

                        
                    }

                    else
                    {
                        MessageBox.Show("Book data not Found!");
                        textBoxInputBook.Clear();
                        textBoxInputBook.Focus();
                    }
                    break;
                case 1:
                    Book bk1 = BookIO.Search(textBoxInputBook.Text);
                    if (bk1 != null)
                    {

                        textBoxAuthorID.Text = Convert.ToString(bk1.authorID);
                        textBoxAuthorFirstName.Text = bk1.firstName;
                        textBoxAuthorLastName.Text = bk1.lastName;
                        textBoxAuthorEmail.Text = bk1.mail;
                        textBoxISBN.Text = bk1.ISBN;
                        textBoxBookTitle.Text = bk1.Title;
                        textBoxPrice.Text = Convert.ToString(bk1.Unit_Price);
                        textBoxQty.Text = Convert.ToString(bk1.Quantity);
                        textBoxYearPublished.Text = Convert.ToString(bk1.publishingYear);
                    }

                    else
                    {
                        MessageBox.Show("Book data not Found!");
                        textBoxInputBook.Clear();
                        textBoxInputBook.Focus();
                    }

                    break;
                case 2:
                    Book bk2 = BookIO.Search(textBoxInputBook.Text);
                    if (bk2 != null)
                    {

                        textBoxAuthorID.Text = Convert.ToString(bk2.authorID);
                        textBoxAuthorFirstName.Text = bk2.firstName;
                        textBoxAuthorLastName.Text = bk2.lastName;
                        textBoxAuthorEmail.Text = bk2.mail;
                        textBoxISBN.Text = bk2.ISBN;
                        textBoxBookTitle.Text = bk2.Title;
                        textBoxPrice.Text = Convert.ToString(bk2.Unit_Price);
                        textBoxQty.Text = Convert.ToString(bk2.Quantity);
                        textBoxYearPublished.Text = Convert.ToString(bk2.publishingYear);
                    }

                    else
                    {
                        MessageBox.Show("Book data not Found!");
                        textBoxInputBook.Clear();
                        textBoxInputBook.Focus();
                    }

                    break;
                default:
                    break;
            }
        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            listViewBook.Items.Clear();
            BookIO.ListBooks(listViewBook);
        }

        private void comboBoxChoiceBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceBook.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelInfoBook.Text = "Please enter the Author ID";
                    textBoxInputBook.Focus();
                    break;
                case 1:
                    labelInfoBook.Text = "Please enter the First Name";
                    textBoxInputBook.Focus();
                    break;
                case 2:
                    labelInfoBook.Text = "Please enter the Last Name";
                    textBoxInputBook.Focus();
                    break;
                default:
                    break;
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
