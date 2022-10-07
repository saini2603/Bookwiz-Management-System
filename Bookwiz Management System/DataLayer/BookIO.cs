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
    public class BookIO
    {
        private static string filePath = Application.StartupPath + @"\Books.dat";
        

        public static void Add(Book bk)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(bk.authorID + "," + bk.firstName + "," + bk.lastName + "," + bk.mail + "," + bk.ISBN + "," + bk.Title + "," + bk.Unit_Price + "," + bk.publishingYear + "," +bk.Quantity );
            sWriter.Close();
            MessageBox.Show("Book Data has been saved.");

        }

        public static void ListBooks(ListView listViewBook)
        {

            StreamReader sReader = new StreamReader(filePath);
            listViewBook.Items.Clear();


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
                item.SubItems.Add(fields[8]);
                listViewBook.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static List<Book> Listbooks()
        {
            List<Book> list1 = new List<Book>();

            StreamReader sReader = new StreamReader(filePath);


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Book bk = new Book();
                bk.authorID = Convert.ToInt32(fields[0]);
                bk.firstName = fields[1];
                bk.lastName = fields[2];
                bk.mail = fields[3];
                bk.ISBN = fields[4];
                bk.Title = fields[5];
                bk.Unit_Price = Convert.ToInt32(fields[6]);
                bk.publishingYear = Convert.ToInt32(fields[7]);
                bk.Quantity = Convert.ToInt32(fields[8]);
                list1.Add(bk);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return list1;
        }


        public static Book Search(string bookname)
        {
            Book bk = new Book();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (bookname == fields[0] || bookname == fields[1] || bookname == fields[2] )
                {

                    bk.authorID = Convert.ToInt32(fields[0]);
                    bk.firstName = fields[1];
                    bk.lastName = fields[2];
                    bk.mail = fields[3];
                    bk.ISBN = fields[4];
                    bk.Title = fields[5];
                    bk.Unit_Price = Convert.ToInt32(fields[6]);
                    bk.publishingYear = Convert.ToInt32(fields[7]);
                    bk.Quantity= Convert.ToInt32(fields[8]);
                    sReader.Close();
                    return bk;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
