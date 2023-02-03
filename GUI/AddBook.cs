using Library.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.GUI
{
    public partial class AddBook : Form
    {
        Repo repo = new();
        public AddBook()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                repo.InsertBook(titleTextBox.Text, authorTextBox.Text);
            }
            catch (Exception)
            {
                throw;
            } 
            finally
            {
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
