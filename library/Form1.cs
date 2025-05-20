using System.Collections;

namespace library
{
    public partial class Form1 : Form
    {

        List<Book> library = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addNewBook(object sender, EventArgs e)
        {
            render();
        }

        private void render()
        {
            bookContainer.Visible = false;

            while (bookContainer.Controls.Count > 0)
            {
                bookContainer.Controls[0].Dispose();
            }

            foreach (var book in library)
            {
                int width, height, padding;

                width = 282;
                height = 32;
                padding = 5;
                bool isAutoSize = true;

                FlowDirection flowDirection = FlowDirection.LeftToRight;

                Font labelStyle = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);

                Color textColor = SystemColors.Control;

                FlowLayoutPanel mainBook = new FlowLayoutPanel();
                FlowLayoutPanel titleLabelContainer = new FlowLayoutPanel();
                FlowLayoutPanel authorLabelContainer = new FlowLayoutPanel();
                FlowLayoutPanel pageNumberLabelContainer = new FlowLayoutPanel();
                FlowLayoutPanel statusLabelContainer = new FlowLayoutPanel();


                Label bookTitle = new Label();
                Label literalTitle = new Label();

                bookTitle.AutoSize = isAutoSize;
                bookTitle.Font = labelStyle;
                bookTitle.ForeColor = textColor;
                bookTitle.Text = "Title";

                literalTitle.AutoSize = isAutoSize;
                literalTitle.ForeColor = textColor;
                literalTitle.Text = book.title;
            



                Label bookAuthor = new Label();
                Label literalAuthor = new Label();

                bookAuthor.AutoSize = isAutoSize;
                bookAuthor.Font = labelStyle;
                bookAuthor.ForeColor = textColor;
                bookAuthor.Text = "Author";

                literalAuthor.AutoSize = isAutoSize;
                literalAuthor.ForeColor = textColor;
                literalAuthor.Text = book.author;
         



                Label bookPageNumber = new Label();
                Label literalPageNumber = new Label();

                bookPageNumber.AutoSize = isAutoSize;
                bookPageNumber.Font = labelStyle;
                bookPageNumber.ForeColor = textColor;
                bookPageNumber.Text = "Number of Page/s";
          
                literalPageNumber.AutoSize = isAutoSize;
                literalPageNumber.ForeColor = textColor;
                literalPageNumber.Text = book.numberOfPages.ToString();




                Label bookStatus = new Label();
                Label literalStatus = new Label();

                bookStatus.AutoSize = isAutoSize;
                bookStatus.Font = labelStyle;
                bookStatus.ForeColor = textColor;
                bookStatus.Text = "Reading Status";

                literalStatus.AutoSize = isAutoSize;
                literalStatus.ForeColor = textColor;

                if (book.readingStatus)
                {
                    literalStatus.Text = "Completed";
                } else literalStatus.Text = "On Read";




                mainBook.BackColor = Color.FromArgb(40, 117, 250);

                mainBook.Size = new Size(327, 256);
                titleLabelContainer.Size = new Size(width, height);
                authorLabelContainer.Size = new Size(width, height);
                pageNumberLabelContainer.Size = new Size(width, height);
                statusLabelContainer.Size = new Size(width, height);

                mainBook.FlowDirection = FlowDirection.TopDown;
                titleLabelContainer.FlowDirection = flowDirection;
                authorLabelContainer.FlowDirection = flowDirection;
                pageNumberLabelContainer.FlowDirection = flowDirection;
                statusLabelContainer.FlowDirection = flowDirection;

                mainBook.Padding = new Padding(20);
                titleLabelContainer.Padding = new Padding(padding);
                authorLabelContainer.Padding = new Padding(padding);
                pageNumberLabelContainer.Padding = new Padding(padding);
                statusLabelContainer.Padding = new Padding(padding);


                titleLabelContainer.Controls.Add(bookTitle);
                titleLabelContainer.Controls.Add(literalTitle);


                authorLabelContainer.Controls.Add(bookAuthor);
                authorLabelContainer.Controls.Add(literalAuthor);


                pageNumberLabelContainer.Controls.Add(bookPageNumber);
                pageNumberLabelContainer.Controls.Add(literalPageNumber);


                statusLabelContainer.Controls.Add(bookStatus);
                statusLabelContainer.Controls.Add(literalStatus);




                Button editButton = new Button();
                editButton.Text = "Edit Book";

                editButton.Cursor = Cursors.Hand;
                editButton.Dock = DockStyle.Right;
                editButton.ForeColor = mainBook.BackColor;
                editButton.BackColor = Color.Transparent;
                editButton.Margin = new Padding(0, 25, 3, 3);
                editButton.Size = new Size(94, 29);

                mainBook.Controls.Add(titleLabelContainer);
                mainBook.Controls.Add(authorLabelContainer);
                mainBook.Controls.Add(pageNumberLabelContainer);
                mainBook.Controls.Add(statusLabelContainer);
                mainBook.Controls.Add(editButton);

                bookContainer.Controls.Add(mainBook);
            }

            bookContainer.Visible = true;
        }
    }
}
