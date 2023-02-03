namespace Library.GUI
{
    partial class BookStatus
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
            this.bookTitle = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.lentToLabel = new System.Windows.Forms.Label();
            this.lentToComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(12, 9);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(29, 15);
            this.bookTitle.TabIndex = 0;
            this.bookTitle.Text = "Title";
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Location = new System.Drawing.Point(142, 9);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(44, 15);
            this.bookAuthor.TabIndex = 1;
            this.bookAuthor.Text = "Author";
            // 
            // lentToLabel
            // 
            this.lentToLabel.AutoSize = true;
            this.lentToLabel.Location = new System.Drawing.Point(12, 58);
            this.lentToLabel.Name = "lentToLabel";
            this.lentToLabel.Size = new System.Drawing.Size(44, 15);
            this.lentToLabel.TabIndex = 2;
            this.lentToLabel.Text = "Lent to";
            // 
            // lentToComboBox
            // 
            this.lentToComboBox.FormattingEnabled = true;
            this.lentToComboBox.Location = new System.Drawing.Point(62, 55);
            this.lentToComboBox.Name = "lentToComboBox";
            this.lentToComboBox.Size = new System.Drawing.Size(209, 23);
            this.lentToComboBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 27);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(124, 23);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(142, 27);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(129, 23);
            this.authorTextBox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 85);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(142, 84);
            this.confirmButton.MaximumSize = new System.Drawing.Size(129, 23);
            this.confirmButton.MinimumSize = new System.Drawing.Size(129, 23);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(129, 23);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // BookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 120);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lentToComboBox);
            this.Controls.Add(this.lentToLabel);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.bookTitle);
            this.MaximumSize = new System.Drawing.Size(299, 159);
            this.MinimumSize = new System.Drawing.Size(299, 159);
            this.Name = "BookStatus";
            this.Text = "Book status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bookTitle;
        private Label bookAuthor;
        private Label lentToLabel;
        private ComboBox lentToComboBox;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private Button cancelButton;
        private Button confirmButton;
    }
}