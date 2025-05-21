using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class BookDataGridView : Form
    {

        List<Book> library = new List<Book>();
        String[] tempData = new string[4];
        DataTable dataTable = new DataTable();
        public BookDataGridView()
        {
            InitializeComponent();

            //this.Clos
        }

        public void setData(List<Book> library)
        {
            this.library = library;
        }

        private void BookDataGridView_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Number Of Pages");
            dataTable.Columns.Add("Reading Status");

            foreach (var book in library)
            {

                tempData[0] = book.title;
                tempData[1] = book.author;
                tempData[2] = book.numberOfPages.ToString();

                if (book.readingStatus)
                {
                    tempData[3] = "Completed";
                }
                else tempData[3] = "On Read";


                dataTable.Rows.Add(tempData);
            }

            bookDataGrid.DataSource = dataTable;
        }

        private void BookDataGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }


}
