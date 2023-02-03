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
    public partial class AddPerson : Form
    {
        Repo repo = new();
        public AddPerson()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                repo.InsertPerson(nameTextBox.Text, surnameTextBox.Text);           
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
    }
}
