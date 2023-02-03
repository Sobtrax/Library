using Library.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.GUI
{
    public partial class editPeopleDetailForm : Form
    {
        List<People> peopleToRemove = new();
        DialogResult dialogResult;
        Repo repo = new();
        List<People> people = new();
        People person = new();
        public editPeopleDetailForm()
        {
            InitializeComponent();
            people = repo.GetPeople();
            fullnameComboBox.DataSource = people;
            fullnameComboBox.DisplayMember = "FullName";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (peopleToRemove != null && peopleToRemove.Count != 0)
            {
                repo.DeletePeople(peopleToRemove);
            }
            else
            {
                var selectedPerson = (People)fullnameComboBox.SelectedValue;
                selectedPerson.name = nameTextBox.Text;
                selectedPerson.surname = surnameTextBox.Text;
                repo.EditPeople(selectedPerson);
            }
            this.Close();
        }

        private void fullnameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedPerson = (People)fullnameComboBox.SelectedValue;
            if (selectedPerson != null)
            {
                nameTextBox.Text = selectedPerson.name;
                surnameTextBox.Text = selectedPerson.surname;
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (repo.PersonWasLending((People)fullnameComboBox.SelectedValue))
            {
                dialogResult = MessageBox.Show("Person you are about to remove is currently lending a book.\x0AProceed anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    removePersonFromDataSource();
                }
            }
            else
            {
                removePersonFromDataSource();
            }

        }
        private void removePersonFromDataSource()
        {
            peopleToRemove.Add((People)fullnameComboBox.SelectedValue);
            people.Remove((People)fullnameComboBox.SelectedValue);
            fullnameComboBox.DataSource = null;
            fullnameComboBox.DataSource = people;
            fullnameComboBox.DisplayMember = "FullName";
            nameTextBox.Enabled = false;
            surnameTextBox.Enabled = false;
        }
    }
}
