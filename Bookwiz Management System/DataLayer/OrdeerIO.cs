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
    public class OrdeerIO
    { 
        private static string filePath = Application.StartupPath + @"\Orders.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        public static void Add(OrderBook odr)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(odr.firstName + "," + odr.lastName + "," + odr.phoneNumber + "," + odr.orderId + "," + odr.bookName + "," + odr.quantity + "," + odr.payableAmount);

            sWriter.Close();
            MessageBox.Show("Client Order Data has been saved.");

        }

        public static void ListOrders(ListView listViewOrder)
        {

            StreamReader sReader = new StreamReader(filePath);
            listViewOrder.Items.Clear();


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
                listViewOrder.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static List<OrderBook> Listorders()
        {
            List<OrderBook> list1 = new List<OrderBook>();

            StreamReader sReader = new StreamReader(filePath);


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                OrderBook odr = new OrderBook();
                odr.firstName = fields[0];
                odr.lastName = fields[1];
                odr.phoneNumber = fields[2];
                odr.orderId= Convert.ToInt32(fields[3]);
                odr.bookName = fields[4];
                odr.quantity = Convert.ToInt32(fields[5]);
                odr.payableAmount = Convert.ToInt32(fields[6]);
                list1.Add(odr);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return list1;
        }


        public static OrderBook Search(string ordername)
        {
            OrderBook odr = new OrderBook();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (ordername == fields[0] || ordername == fields[1] )
                {

                    odr.orderId = Convert.ToInt32(fields[3]);
                    odr.firstName = fields[0];
                    odr.lastName = fields[1];
                    odr.phoneNumber = fields[2];
                    odr.bookName = fields[4];
                    odr.quantity = Convert.ToInt32(fields[5]);
                    odr.payableAmount= Convert.ToInt32(fields[6]);
                    
                    sReader.Close();
                    return odr;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
        public static OrderBook Search(int orderId)
        {
            OrderBook odr = new OrderBook();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (orderId == Convert.ToInt32(fields[3]))
                {
                    odr.orderId = Convert.ToInt32(fields[3]);
                    odr.firstName = fields[0];
                    odr.lastName = fields[1];
                    odr.phoneNumber = fields[2];
                    odr.bookName = fields[4];
                    odr.quantity = Convert.ToInt32(fields[5]);
                    odr.payableAmount = Convert.ToInt32(fields[6]);
                    return odr;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
        public static void Delete(int orderId)
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            while (line != null)
            {
                string[] fields = line.Split(',');
                if ((orderId) != (Convert.ToInt32(fields[3])))
                {

                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);


                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            sWriter.Close();

            File.Delete(filePath);
            File.Move(fileTemp, filePath);

        }
    }
}

