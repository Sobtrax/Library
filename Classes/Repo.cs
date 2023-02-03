using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Library.Classes
{
    public class Repo
    {       
        public List<People> GetPeople()
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.Query<People>($"select * from People").ToList();
                return output;
            }
        }

        public List<Book> GetBooksByTitle(string title)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.Query<Book>($"select * from Books where book_title like '%{title}%'").ToList();
                return output;
            }
        }
        public List<Book> GetBooks()
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.Query<Book>($"select * from Books").ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                List<People> people = new List<People>();
                people.Add(new People { name = firstName, surname = lastName });

                connection.Execute("dbo.People_Insert @name, @surname", people);
            }
        }

        public void InsertBook(string title, string author)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                List<Book> book = new List<Book>();
                book.Add(new Book { book_title = title, book_author = author });

                connection.Execute("dbo.Book_Insert @book_title, @book_author", book);
            }
        }
        public void NewLend(Lend l)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                connection.Execute("dbo.InsertLendRecord @people_id, @book_id", l);
            }
        }

        public bool WasLent(Book book)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.QueryFirstOrDefault($"select * from Lend_Books where book_id = {book.id}");
                if (output != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void RemoveLendRecord(Book book)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                connection.Execute($"delete from Lend_Books where book_id = {book.id}");
            }
        }

        public int LentTo(Book book)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.Query<int>($"select people_id from Lend_Books, Books where book_id = Books.id AND book_id = @book_id", new { @book_id = book.id });
                if (output.ToList().Count() > 0)
                    return output.ToList()[0];
                else
                    return 0;
            }
        }

        public void DeleteBook(Book book)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                connection.Execute($"delete from Books where id = {book.id}");
                connection.Execute($"delete from Lend_Books where book_id = @book_id", new {@book_id = book.id});
            }
        }

        public void EditPeople(People person)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                connection.Execute($"update People set name = @name, surname = @surname where id = @id", new {@name = person.name, @surname = person.surname, @id = person.id});
            }
        }

        internal void DeletePeople(List<People> peopleToRemove)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                foreach(var person in peopleToRemove)
                {
                    connection.Execute("delete from people where id = @id", new {@id = person.id});               
                }              
            }
        }

        internal bool PersonWasLending(People person)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.QueryFirstOrDefault($"select * from Lend_Books, People where Lend_Books.people_id = @id and People.id = Lend_Books.people_id", new {@id = person.id});
                if (output != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal void UpdateBook(Book book)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                connection.Execute($"update Books set book_title = @title, book_author = @book_author where id = @id", new { @title = book.book_title, @book_author = book.book_author, @id = book.id });
            }
        }

        internal void UpdateLend(Lend lend)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                connection.Execute($"update Lend_Books set book_id = @book_id, people_id = @people_id where id = @id", new {@book_id = lend.book_id, @people_id = lend.people_id, @id = lend.id});
            }
        }

        internal int GetLendId(Book book)
        {
            using (IDbConnection connection = new SqlConnection(helper.CnnVal("Library")))
            {
                var output = connection.Query<int>($"select id from Lend_Books where book_id = @book_id", new { @book_id = book.id });
                if (output.ToList().Count() > 0)
                    return output.ToList()[0];
                else
                    return 0;
            }
        }
    }
}
