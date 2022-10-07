using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bookwiz_Management_System.Business;

namespace Bookwiz_Management_System.DataLayer
{
   public class EmployeeIO
    {
        private static string filePath = Application.StartupPath + @"\Employees.dat";
       

        public static void Add(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName);
            sWriter.Close();
            MessageBox.Show("Employee Data has been saved.");

        }

        public static void ListEmployees(ListView listViewEmployee)
        {

            StreamReader sReader = new StreamReader(filePath);
            listViewEmployee.Items.Clear();


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                listViewEmployee.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static List<Employee> Listemployees()
        {
            List<Employee> list1 = new List<Employee>();

            StreamReader sReader = new StreamReader(filePath);


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(fields[0]);
                emp.FirstName = fields[1];
                emp.LastName = fields[2];
                list1.Add(emp);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return list1;
        }

        public static Employee Search(int empId)
        {
             Employee emp = new Employee();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (empId == Convert.ToInt32(fields[0]))
                {
                    emp.EmployeeId = Convert.ToInt32(fields[0]);
                    emp.FirstName = fields[1];
                    emp.LastName = fields[2];
                    sReader.Close();
                    return emp;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }

        public static Employee Search(string empname)
        {
            Employee emp = new Employee();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (empname == fields[1] || empname == fields[2])
                {
                    emp.EmployeeId = Convert.ToInt32(fields[0]);
                    emp.FirstName = fields[1];
                    emp.LastName = fields[2];
                    sReader.Close();
                    return emp;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
