namespace Library
{
    partial class library
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
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.editPeopleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 64);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowTemplate.Height = 25;
            this.booksDataGridView.Size = new System.Drawing.Size(410, 374);
            this.booksDataGridView.TabIndex = 0;
            this.booksDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellDoubleClick);
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(77, 6);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(224, 23);
            this.textBoxBookTitle.TabIndex = 1;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(12, 9);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(59, 15);
            this.labelBookTitle.TabIndex = 2;
            this.labelBookTitle.Text = "Book Title";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(314, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search/refresh";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(12, 35);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(93, 23);
            this.addBookButton.TabIndex = 4;
            this.addBookButton.Text = "Add a book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(215, 35);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(93, 23);
            this.addPersonButton.TabIndex = 5;
            this.addPersonButton.Text = "Add a Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(111, 35);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(98, 23);
            this.removeBookButton.TabIndex = 6;
            this.removeBookButton.Text = "Remove a book";
            this.removeBookButton.UseVisualStyleBackColor = true;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // editPeopleButton
            // 
            this.editPeopleButton.Location = new System.Drawing.Point(314, 35);
            this.editPeopleButton.Name = "editPeopleButton";
            this.editPeopleButton.Size = new System.Drawing.Size(108, 23);
            this.editPeopleButton.TabIndex = 7;
            this.editPeopleButton.Text = "Edit people detail";
            this.editPeopleButton.UseVisualStyleBackColor = true;
            this.editPeopleButton.Click += new System.EventHandler(this.editPeopleButton_Click);
            // 
            // library
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.editPeopleButton);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.booksDataGridView);
            this.MaximumSize = new System.Drawing.Size(450, 489);
            this.MinimumSize = new System.Drawing.Size(450, 489);
            this.Name = "library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView booksDataGridView;
        private TextBox textBoxBookTitle;
        private Label labelBookTitle;
        private Button searchButton;
        private Button addBookButton;
        private Button addPersonButton;
        private Button removeBookButton;
        private Button editPeopleButton;
    }
}