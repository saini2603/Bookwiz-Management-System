using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookwiz_Management_System.Business;
using System.IO;

namespace Bookwiz_Management_System.DataLayer
{
    public class UserIO
    {
        private static string filePath = Application.StartupPath + @"\Users.dat";
        

        public static void Add(User usr)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(usr.UserId + "," + usr.FirstName + "," + usr.LastName);
            sWriter.Close();
            MessageBox.Show("User Data has been saved.");

        }

        public static void ListUsers(ListView listViewUser)
        {

            StreamReader sReader = new StreamReader(filePath);
            listViewUser.Items.Clear();


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                listViewUser.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static List<User> Listusers()
        {
            List<User> list1 = new List<User>();

            StreamReader sReader = new StreamReader(filePath);


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                User usr = new User();
                usr.UserId = Convert.ToInt32(fields[0]);
                usr.FirstName = fields[1];
                usr.LastName = fields[2];
                list1.Add(usr);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return list1;
        }

        public static User Search(int userId)
        {
            User usr = new User();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userId == Convert.ToInt32(fields[0]))
                {
                    usr.UserId = Convert.ToInt32(fields[0]);
                    usr.FirstName = fields[1];
                    usr.LastName = fields[2];
                    sReader.Close();
                    return usr;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
        public static User Search(string userfname)
        {
            User usr = new User();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userfname == fields[1] || userfname == fields[2])
                {
                    usr.UserId = Convert.ToInt32(fields[0]);
                    usr.FirstName = fields[1];
                    usr.LastName = fields[2];
                    sReader.Close();
                    return usr;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
