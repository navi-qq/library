namespace library
{
    partial class BookDataGridView
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
            bookDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // bookDataGrid
            // 
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Dock = DockStyle.Fill;
            bookDataGrid.Location = new Point(0, 0);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.RowHeadersWidth = 51;
            bookDataGrid.Size = new Size(836, 469);
            bookDataGrid.TabIndex = 0;
            // 
            // BookDataGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 469);
            Controls.Add(bookDataGrid);
            Name = "BookDataGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDataGridView";
            FormClosed += BookDataGridView_FormClosed;
            Load += BookDataGridView_Load;
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView bookDataGrid;
    }
}