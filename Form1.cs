using Library.GUI;
using Library.Classes;
namespace Library
{
    public partial class library : Form
    {
        List<Book> books = new List<Book>();
        Book book = new();
        Repo repo = new();
        DialogResult dialogResultRemoveBook;
        DialogResult dialogResultBookStatus;
        private AddBook addBook = new AddBook();
        private AddPerson addPerson = new AddPerson();
        public library()
        {
            InitializeComponent();
            books = repo.GetBooks();
            refresh();
        }
            
        private void searchButton_Click(object sender, EventArgs e)
        {
            books = repo.GetBooksByTitle(textBoxBookTitle.Text);
            refresh();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (addBook.IsDisposed || addBook == null)
            {
                addBook = new AddBook();
            }
            addBook.Show();
            addBook.BringToFront();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (addPerson.IsDisposed || addPerson == null)
            {
                addPerson = new AddPerson();
            }
            addPerson.Show();
            addPerson.BringToFront();
        }

        private void booksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dialogResultBookStatus = MessageBox.Show("Do you want to edit book status (No) or book details (Yes)?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); //todo: ask wheter you want to edit book details or change lent status
            DataGridViewRow? row = booksDataGridView.CurrentRow;
            book = books[row.Index];
            if (dialogResultBookStatus == DialogResult.Yes)
            {
                BookStatus bookStatus = new BookStatus(book, 2);
                if (bookStatus.IsDisposed || bookStatus == null)
                {
                    bookStatus = new BookStatus(book, 2);
                }
                bookStatus.Show();
                bookStatus.BringToFront();
            }
            else if (dialogResultBookStatus == DialogResult.No)
            {
                BookStatus bookStatus = new BookStatus(book, 1);
                if (bookStatus.IsDisposed || bookStatus == null)
                {
                    bookStatus = new BookStatus(book, 1);
                }
                bookStatus.Show();
                bookStatus.BringToFront();
            }
           
        }

        private void editPeopleButton_Click(object sender, EventArgs e)
        {
            editPeopleDetailForm edit = new editPeopleDetailForm();
            if (edit.IsDisposed || edit == null)
            {
                edit = new editPeopleDetailForm();
            }
            edit.Show();
            edit.BringToFront();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            Book bookToDelete;
            if (booksDataGridView.CurrentRow != null)
            {
                bookToDelete = (Book)booksDataGridView.CurrentRow.DataBoundItem;
                if (repo.WasLent(bookToDelete))
                {
                    dialogResultRemoveBook = MessageBox.Show("Book you want to remove is currently lent to someone.\x0AProceed anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResultRemoveBook == DialogResult.Yes)
                    {
                        books.RemoveAt(booksDataGridView.CurrentRow.Index);
                        repo.DeleteBook(bookToDelete);
                        refresh();
                    }
                }
                else
                {
                    books.RemoveAt(booksDataGridView.CurrentRow.Index);
                    repo.DeleteBook(bookToDelete);
                    refresh();
                }            
            }           
        }
        private void refresh()
        {
            booksDataGridView.DataSource = null;
            booksDataGridView.DataSource = books;
            booksDataGridView.Columns[0].HeaderText = "Book title";
            booksDataGridView.Columns[1].HeaderText = "Book author";
        }
    }
}