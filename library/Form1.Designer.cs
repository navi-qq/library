namespace library
{
    partial class Form1
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
            bookContainer = new FlowLayoutPanel();
            bookExample = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            editButton = new Button();
            removeBookButton = new Button();
            label5 = new Label();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPagesField).BeginInit();
            bookContainer.SuspendLayout();
            bookExample.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 117, 250);
            flowLayoutPanel1.Controls.Add(groupBox1);
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
            // bookContainer
            // 
            bookContainer.AutoScroll = true;
            bookContainer.BackColor = SystemColors.ButtonFace;
            bookContainer.Controls.Add(bookExample);
            bookContainer.Dock = DockStyle.Fill;
            bookContainer.Location = new Point(467, 0);
            bookContainer.Name = "bookContainer";
            bookContainer.Padding = new Padding(20);
            bookContainer.Size = new Size(852, 596);
            bookContainer.TabIndex = 1;
            // 
            // bookExample
            // 
            bookExample.BackColor = Color.FromArgb(40, 117, 250);
            bookExample.Controls.Add(flowLayoutPanel5);
            bookExample.Controls.Add(flowLayoutPanel6);
            bookExample.Controls.Add(flowLayoutPanel7);
            bookExample.Controls.Add(flowLayoutPanel8);
            bookExample.Controls.Add(editButton);
            bookExample.Controls.Add(removeBookButton);
            bookExample.FlowDirection = FlowDirection.TopDown;
            bookExample.Location = new Point(23, 23);
            bookExample.Name = "bookExample";
            bookExample.Padding = new Padding(20);
            bookExample.Size = new Size(327, 284);
            bookExample.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Controls.Add(label8);
            flowLayoutPanel5.Location = new Point(23, 23);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(5);
            flowLayoutPanel5.Size = new Size(282, 32);
            flowLayoutPanel5.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(8, 5);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 0;
            label7.Text = "Title";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(54, 5);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 7;
            label8.Text = "Harry Potter";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label9);
            flowLayoutPanel6.Controls.Add(label10);
            flowLayoutPanel6.Location = new Point(23, 61);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(5);
            flowLayoutPanel6.Size = new Size(282, 32);
            flowLayoutPanel6.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(8, 5);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 0;
            label9.Text = "Author";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(73, 5);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 7;
            label10.Text = "J.K Rowling";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label11);
            flowLayoutPanel7.Controls.Add(label12);
            flowLayoutPanel7.Location = new Point(23, 99);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(5);
            flowLayoutPanel7.Size = new Size(282, 32);
            flowLayoutPanel7.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(8, 5);
            label11.Name = "label11";
            label11.Size = new Size(138, 20);
            label11.TabIndex = 0;
            label11.Text = "Number of Page/s";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(152, 5);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 7;
            label12.Text = "36";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(label13);
            flowLayoutPanel8.Controls.Add(label14);
            flowLayoutPanel8.Location = new Point(23, 137);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(5);
            flowLayoutPanel8.Size = new Size(282, 32);
            flowLayoutPanel8.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(8, 5);
            label13.Name = "label13";
            label13.Size = new Size(114, 20);
            label13.TabIndex = 0;
            label13.Text = "Reading Status";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(128, 5);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 7;
            label14.Text = "Completed";
            // 
            // editButton
            // 
            editButton.BackColor = Color.Transparent;
            editButton.Cursor = Cursors.Hand;
            editButton.Dock = DockStyle.Right;
            editButton.ForeColor = Color.FromArgb(40, 117, 250);
            editButton.Location = new Point(211, 197);
            editButton.Margin = new Padding(0, 25, 3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 10;
            editButton.Text = "Edit Book";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += handleEditBook;
            // 
            // removeBookButton
            // 
            removeBookButton.BackColor = Color.FromArgb(40, 117, 250);
            removeBookButton.Dock = DockStyle.Right;
            removeBookButton.ForeColor = SystemColors.Control;
            removeBookButton.Location = new Point(183, 232);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(122, 29);
            removeBookButton.TabIndex = 11;
            removeBookButton.Text = "Remove Book";
            removeBookButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
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
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookPagesField).EndInit();
            bookContainer.ResumeLayout(false);
            bookExample.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
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
        private FlowLayoutPanel bookExample;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label7;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label11;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label13;
        private Label label14;
        private Button editButton;
        private Button removeBookButton;
    }
}
