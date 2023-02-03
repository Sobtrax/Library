using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Library.GUI
{
    public partial class BookStatus : Form
    {
        Lend lend = new();
        Book book = new();
        Repo repo = new();
        DialogResult dialogResult;
        List<People> people = new();
        People empty = new();
        int Choice;
        public BookStatus()
        {
            InitializeComponent();
        }
        public BookStatus(Book _book, int choice)
        {
            Choice = choice;
            InitializeComponent();
            book = _book;
            lend.id = repo.GetLendId(book);
            people = repo.GetPeople();
            people.Insert(0, empty);
            lentToComboBox.DataSource = people;
            lentToComboBox.DisplayMember = "FullName";
            lentToComboBox.ValueMember = "id";
            var index = people.IndexOf(people.FirstOrDefault(x => x.id == repo.LentTo(book))); 
            lentToComboBox.SelectedIndex = index;
            titleTextBox.Text = book.book_title;
            authorTextBox.Text = book.book_author;
            if (choice == 2)
            {
                lentToComboBox.Enabled = false;
                titleTextBox.ReadOnly = false;
                authorTextBox.ReadOnly = false;
            }
            if (choice == 1)
            {
                lentToComboBox.Enabled = true;
                titleTextBox.ReadOnly = true;
                authorTextBox.ReadOnly = true;
            }            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (Choice == 1)
            {
                if (lentToComboBox.SelectedIndex == 0)
                {
                    if (repo.WasLent(book))
                    {
                        book.Status = "Available";
                        repo.RemoveLendRecord(book);
                    }
                }
                else
                {
                    if (!repo.WasLent(book))
                    {
                        lend.book_id = book.id;
                        lend.people_id = (int)lentToComboBox.SelectedValue;
                        repo.NewLend(lend);
                    }
                    else
                    {
                        dialogResult = MessageBox.Show("This book is already lent to someone else. Proceed anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lend.book_id = book.id;
                            lend.people_id = (int)lentToComboBox.SelectedValue;
                            repo.UpdateLend(lend);
                        }
                    }
                }
            }
            else if (Choice == 2)
            {
                if (repo.WasLent(book))
                {
                    dialogResult = MessageBox.Show("This book is currently lent to someone. Edit Anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        book.book_title = titleTextBox.Text;
                        book.book_author = authorTextBox.Text;
                        repo.UpdateBook(book);
                    }
                }
                else
                {
                    book.book_title = titleTextBox.Text;
                    book.book_author = authorTextBox.Text;
                    repo.UpdateBook(book);
                }                           
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
