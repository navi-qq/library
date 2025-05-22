namespace library
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            emailField = new TextBox();
            passwordField = new TextBox();
            confirmPasswordField = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 117, 250);
            label1.Location = new Point(15, 55);
            label1.Name = "label1";
            label1.Size = new Size(195, 54);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(40, 117, 250);
            label2.Location = new Point(22, 161);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(40, 117, 250);
            label3.Location = new Point(22, 253);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(40, 117, 250);
            label4.Location = new Point(21, 349);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // emailField
            // 
            emailField.Cursor = Cursors.Hand;
            emailField.Location = new Point(21, 184);
            emailField.Name = "emailField";
            emailField.Size = new Size(404, 27);
            emailField.TabIndex = 4;
            // 
            // passwordField
            // 
            passwordField.Cursor = Cursors.Hand;
            passwordField.Location = new Point(24, 276);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(401, 27);
            passwordField.TabIndex = 5;
            // 
            // confirmPasswordField
            // 
            confirmPasswordField.Cursor = Cursors.Hand;
            confirmPasswordField.Location = new Point(22, 372);
            confirmPasswordField.Name = "confirmPasswordField";
            confirmPasswordField.PasswordChar = '*';
            confirmPasswordField.Size = new Size(401, 27);
            confirmPasswordField.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 117, 250);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(302, 442);
            button1.Name = "button1";
            button1.Size = new Size(121, 58);
            button1.TabIndex = 7;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += handleAccountRegistration;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 532);
            Controls.Add(button1);
            Controls.Add(confirmPasswordField);
            Controls.Add(passwordField);
            Controls.Add(emailField);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox emailField;
        private TextBox passwordField;
        private TextBox confirmPasswordField;
        private Button button1;
    }
}