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
    public class clientIO
    {
        private static string filePath = Application.StartupPath + @"\Clients.dat";
       

        public static void Add(client clt)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(clt.FirstName + "," + clt.LastName + "," + clt.street + "," + clt.city + "," + clt.phoneNumber + "," + clt.faxNumber + "," + clt.postalCode + "," + clt.creditLimit);
            sWriter.Close();
            MessageBox.Show("Client Data has been saved.");

        }

        public static void ListClients(ListView listViewClient)
        {

            StreamReader sReader = new StreamReader(filePath);
            listViewClient.Items.Clear();


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                item.SubItems.Add(fields[5]);
                item.SubItems.Add(fields[6]);
                item.SubItems.Add(fields[7]);
                listViewClient.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static List<client> Listclients()
        {
            List<client> list1 = new List<client>();

            StreamReader sReader = new StreamReader(filePath);


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                client clt = new client();
                clt.FirstName = fields[0];
                clt.LastName = fields[1];
                clt.street = fields[2];
                clt.city = fields[3];
                clt.phoneNumber = fields[4];
                clt.faxNumber = fields[5];
                clt.postalCode = fields[6];
                clt.creditLimit = Convert.ToInt32(fields[7]);
                list1.Add(clt);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return list1;
        }

        
        public static client Search(string clientname)
        {
            client clt=new client();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (clientname == fields[0] || clientname == fields[1])
                {
                    
                    clt.FirstName = fields[0];
                    clt.LastName = fields[1];
                    clt.street = fields[2];
                    clt.city = fields[3];
                    clt.phoneNumber = fields[4];
                    clt.faxNumber = fields[5];
                    clt.postalCode = fields[6];
                    clt.creditLimit = Convert.ToInt32(fields[7]);
                    sReader.Close();
                    return clt;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
