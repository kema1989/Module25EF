using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF
{
    public class BookRepository
    {
        private AppContext db;
        public BookRepository(AppContext db)
        {
            this.db = db;
        }

        public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return db.Books.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void Delete(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public void UpdateById(int id)
        {
            db.Books.FirstOrDefault(b => b.Id == id).ReleaseYear = Convert.ToInt32(Console.ReadLine());
            db.SaveChanges();
        }
    }
}
