namespace library
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            addBookButton = new Button();
            bookPagesField = new NumericUpDown();
            bookAuthorField = new TextBox();
            bookTitleField = new TextBox();
            bookReadingStatus = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            bookContainer = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPagesField).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 117, 250);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(467, 596);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addBookButton);
            groupBox1.Controls.Add(bookPagesField);
            groupBox1.Controls.Add(bookAuthorField);
            groupBox1.Controls.Add(bookTitleField);
            groupBox1.Controls.Add(bookReadingStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD NEW BOOK";
            // 
            // addBookButton
            // 
            addBookButton.BackColor = Color.Transparent;
            addBookButton.Cursor = Cursors.Hand;
            addBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBookButton.ForeColor = Color.FromArgb(40, 117, 250);
            addBookButton.Location = new Point(315, 255);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(87, 39);
            addBookButton.TabIndex = 9;
            addBookButton.Text = "ADD";
            addBookButton.UseVisualStyleBackColor = false;
            addBookButton.Click += addNewBook;
            // 
            // bookPagesField
            // 
            bookPagesField.Cursor = Cursors.Hand;
            bookPagesField.Font = new Font("Segoe UI", 7.8F);
            bookPagesField.Location = new Point(186, 161);
            bookPagesField.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            bookPagesField.Name = "bookPagesField";
            bookPagesField.Size = new Size(67, 25);
            bookPagesField.TabIndex = 8;
            // 
            // bookAuthorField
            // 
            bookAuthorField.Cursor = Cursors.Hand;
            bookAuthorField.Font = new Font("Segoe UI", 6F);
            bookAuthorField.Location = new Point(94, 118);
            bookAuthorField.Name = "bookAuthorField";
            bookAuthorField.Size = new Size(125, 21);
            bookAuthorField.TabIndex = 6;
            // 
            // bookTitleField
            // 
            bookTitleField.Cursor = Cursors.Hand;
            bookTitleField.Font = new Font("Segoe UI", 6F);
            bookTitleField.Location = new Point(73, 79);
            bookTitleField.Name = "bookTitleField";
            bookTitleField.Size = new Size(125, 21);
            bookTitleField.TabIndex = 5;
            // 
            // bookReadingStatus
            // 
            bookReadingStatus.AutoSize = true;
            bookReadingStatus.Cursor = Cursors.Hand;
            bookReadingStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookReadingStatus.Location = new Point(34, 259);
            bookReadingStatus.Name = "bookReadingStatus";
            bookReadingStatus.Size = new Size(94, 21);
            bookReadingStatus.TabIndex = 4;
            bookReadingStatus.Text = "Completed";
            bookReadingStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(29, 233);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 3;
            label4.Text = "Reading Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(29, 161);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 2;
            label3.Text = "Number of Page/s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 117);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 77);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.FromArgb(40, 117, 250);
            button1.Location = new Point(130, 386);
            button1.Margin = new Padding(120, 50, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(198, 44);
            button1.TabIndex = 0;
            button1.Text = "Show DataGridView";
            button1.UseVisualStyleBackColor = true;
            button1.Click += showDataGridView;
            // 
            // bookContainer
            // 
            bookContainer.AutoScroll = true;
            bookContainer.BackColor = SystemColors.ButtonFace;
            bookContainer.Dock = DockStyle.Fill;
            bookContainer.Location = new Point(467, 0);
            bookContainer.Name = "bookContainer";
            bookContainer.Padding = new Padding(20);
            bookContainer.Size = new Size(852, 596);
            bookContainer.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 596);
            Controls.Add(bookContainer);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookPagesField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel bookContainer;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown bookPagesField;
        private TextBox bookAuthorField;
        private TextBox bookTitleField;
        private CheckBox bookReadingStatus;
        private Button addBookButton;
        private Button button1;
    }
}
