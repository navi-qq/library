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

        public void setData(Book book)
        {
            library.Add(book);
        }

        private void BookDataGridView_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Number Of Pages");
            dataTable.Columns.Add("Reading Status");

            foreach (var book in library)
            {

                tempData[0] = book.GetTitle();
                tempData[1] = book.GetAuthor();
                tempData[2] = book.GetNumberOfPages().ToString();

                if (book.GetReadingStatus())
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
