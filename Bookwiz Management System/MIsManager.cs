using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.Business;
using Bookwiz_Management_System.DataLayer;
using Bookwiz_Management_System.Validator;


namespace Bookwiz_Management_System
{
    public partial class MIsManager : Form
    {
        public MIsManager()
        {
            InitializeComponent();
            buttonListUsers.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceEmployee.SelectedIndex;
            switch (choice)
            {
                case -1:
                    MessageBox.Show("Please select the search option");
                    break;
                case 0:
                    Employee emp = EmployeeIO.Search(Convert.ToInt32(textBoxInputEmployee.Text));
                    if (emp != null)
                    {
                        textBoxEMPID.Text = (emp.EmployeeId).ToString();
                        textBoxEmpFirstName.Text =emp.FirstName;
                        textBoxEmpLastName.Text = emp.LastName;

                    }

                    else
                    {
                        MessageBox.Show("Student data not Found!");
                        textBoxInputUser.Clear();
                        textBoxInputUser.Focus();
                    }
                    break;
                case 1:
                    Employee emp1 = EmployeeIO.Search(textBoxInputEmployee.Text);
                    if (emp1!= null)
                    {
                        textBoxEMPID.Text = (emp1.EmployeeId).ToString();
                        textBoxEmpFirstName.Text = emp1.FirstName;
                        textBoxEmpLastName.Text = emp1.LastName;

                    }

                    else
                    {
                        MessageBox.Show("Student data not Found!");
                        textBoxInputUser.Clear();
                        textBoxInputUser.Focus();
                    }
                    break;
                case 2:
                    Employee emp2 = EmployeeIO.Search(textBoxInputEmployee.Text);
                    if (emp2 != null)
                    {
                        textBoxEMPID.Text = (emp2.EmployeeId).ToString();
                        textBoxEmpFirstName.Text = emp2.FirstName;
                        textBoxEmpLastName.Text = emp2.LastName;

                    }

                    else
                    {
                        MessageBox.Show("Student data not Found!");
                        textBoxInputUser.Clear();
                        textBoxInputUser.Focus();
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceUser.SelectedIndex;
            switch (choice)
            {
                case -1:
                    MessageBox.Show("Please select the search option");
                    break;
                case 0:
                    User usr = UserIO.Search(Convert.ToInt32(textBoxInputUser.Text));
                    if (usr != null)
                    {
                        textBoxUID.Text = (usr.UserId).ToString();
                        textBoxUserFirstName.Text = usr.FirstName;
                        textBoxUserLastName.Text = usr.LastName;

                    }

                    else
                    {
                        MessageBox.Show("Student data not Found!");
                        textBoxInputUser.Clear();
                        textBoxInputUser.Focus();
                    }
                    break;
                case 1:
                    User usr1 = UserIO.Search(textBoxInputUser.Text);
                    if (usr1 != null)
                    {
                        textBoxUID.Text = (usr1.UserId).ToString();
                        textBoxUserFirstName.Text = usr1.FirstName;
                        textBoxUserLastName.Text = usr1.LastName;

                    }

                    else
                    {
                        MessageBox.Show("Student data not Found!");
                        textBoxInputUser.Clear();
                        textBoxInputUser.Focus();
                    }
                    break;
                case 2:
                    User usr2 = UserIO.Search(textBoxInputUser.Text);
                    if (usr2 != null)
                    {
                        textBoxUID.Text = (usr2.UserId).ToString();
                        textBoxUserFirstName.Text = usr2.FirstName;
                        textBoxUserLastName.Text = usr2.LastName;

                    }

                    else
                    {
                        MessageBox.Show("Student data not Found!");
                        textBoxInputUser.Clear();
                        textBoxInputUser.Focus();
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            listViewManager.Items.Clear();
            UserIO.ListUsers(listViewManager);
        }

        private void textBoxInputUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelInfoUser_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxChoiceUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceUser.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelInfoUser.Text = "Please enter the User ID";
                    textBoxInputUser.Focus();
                    break;
                case 1:
                    labelInfoUser.Text = "Please enter the First Name";
                    textBoxInputUser.Focus();
                    break;
                case 2:
                    labelInfoUser.Text = "Please enter the Last Name";
                    textBoxInputUser.Focus();
                    break;
                default:
                    break;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            List<User> list1 = UserIO.Listusers();
            if (validation.IsValidID(textBoxUID) && (validation.IsValidName(textBoxUserFirstName)) && (validation.IsValidName(textBoxUserLastName)) && validation.IsUniqueID(list1, Convert.ToInt32(textBoxUID.Text)))

            { 

                User usr = new User();

                usr.UserId = Convert.ToInt32(textBoxUID.Text);
                usr.FirstName = textBoxUserFirstName.Text;
                usr.LastName = textBoxUserLastName.Text;
                UserIO.Add(usr);
                ClearAll();

            }
        }
        private void ClearAll()
        {
            textBoxUID.Clear();
            textBoxUserFirstName.Clear();
            textBoxUserLastName.Clear();
            textBoxUID.Focus();

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> list2 = EmployeeIO.Listemployees();
            if (ValidatorEmployee.IsValidID(textBoxEMPID) && (ValidatorEmployee.IsValidName(textBoxEmpFirstName)) && (ValidatorEmployee.IsValidName(textBoxEmpLastName)) && ValidatorEmployee.IsUniqueID(list2, Convert.ToInt32(textBoxEMPID.Text)))

            {

                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(textBoxEMPID.Text);
                emp.FirstName = textBoxEmpFirstName.Text;
                emp.LastName = textBoxEmpLastName.Text;
                EmployeeIO.Add(emp);
                ClearAll();

            }

        }

        private void buttonListEmployees_Click(object sender, EventArgs e)
        {
            listViewManager.Items.Clear();
            EmployeeIO.ListEmployees(listViewManager);

        }

        private void comboBoxChoiceEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxChoiceEmployee.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelInfoUser.Text = "Please enter the Employee ID";
                    textBoxInputEmployee.Focus();
                    break;
                case 1:
                    labelInfoUser.Text = "Please enter the First Name";
                    textBoxInputEmployee.Focus();
                    break;
                case 2:
                    labelInfoUser.Text = "Please enter the Last Name";
                    textBoxInputEmployee.Focus();
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

        private void MIsManager_Load(object sender, EventArgs e)
        {

        }
    }
}
