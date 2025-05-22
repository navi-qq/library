namespace library
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            passwordLoginField = new TextBox();
            emailLoginField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            showPassword = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 117, 250);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(440, 449);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 105);
            pictureBox1.Margin = new Padding(138, 105, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(165, 276);
            label5.Margin = new Padding(165, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 11;
            label5.Text = "Hello, User!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(454, 44);
            label1.Name = "label1";
            label1.Size = new Size(262, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            // 
            // passwordLoginField
            // 
            passwordLoginField.Cursor = Cursors.Hand;
            passwordLoginField.Font = new Font("Microsoft Sans Serif", 8.25F);
            passwordLoginField.Location = new Point(460, 219);
            passwordLoginField.Name = "passwordLoginField";
            passwordLoginField.PasswordChar = '*';
            passwordLoginField.PlaceholderText = "@JohnDoe123";
            passwordLoginField.Size = new Size(462, 23);
            passwordLoginField.TabIndex = 2;
            // 
            // emailLoginField
            // 
            emailLoginField.Cursor = Cursors.Hand;
            emailLoginField.Font = new Font("Microsoft Sans Serif", 8.25F);
            emailLoginField.Location = new Point(460, 148);
            emailLoginField.Name = "emailLoginField";
            emailLoginField.PlaceholderText = "johndoe@email.com";
            emailLoginField.Size = new Size(462, 23);
            emailLoginField.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(460, 128);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(460, 199);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 117, 250);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(460, 269);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 10, 0, 10);
            button1.Size = new Size(108, 50);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += handleAccountLogin;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(577, 420);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(735, 420);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Cursor = Cursors.Hand;
            showPassword.Location = new Point(790, 248);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(132, 24);
            showPassword.TabIndex = 9;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += handleShowPassword;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 449);
            Controls.Add(showPassword);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(emailLoginField);
            Controls.Add(passwordLoginField);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox passwordLoginField;
        private TextBox emailLoginField;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
        private CheckBox showPassword;
        private PictureBox pictureBox1;
        private Label label5;
    }
}