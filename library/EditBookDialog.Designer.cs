namespace library
{
    partial class EditBookDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 117, 250);
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(252, 358);
            button1.Name = "button1";
            button1.Size = new Size(119, 52);
            button1.TabIndex = 0;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
    
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(377, 358);
            button2.Name = "button2";
            button2.Size = new Size(119, 52);
            button2.TabIndex = 1;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancelButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 117, 250);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 147);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(478, 34);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(40, 117, 250);
            label2.Location = new Point(16, 119);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 4;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(40, 117, 250);
            label3.Location = new Point(18, 222);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 6;
            label3.Text = "Number Of Page/s";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Location = new Point(164, 219);
            numericUpDown1.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(40, 117, 250);
            label4.Location = new Point(18, 267);
            label4.Name = "label4";
            label4.Size = new Size(118, 19);
            label4.TabIndex = 8;
            label4.Text = "Reading Status";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(23, 289);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 21);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Completed";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // EditBookDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 422);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditBookDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Book";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private CheckBox checkBox1;
    }
}