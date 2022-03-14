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
        public BookRepository()
        {
            db = new AppContext();
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

        // Задание 25.5.4
        // 1)
        public List<Book> GetBooksByGenre(string genreTitle)
        {
            return db.Genres.FirstOrDefault(g => g.Title == genreTitle).Books;
        }

        public List<Book> GetBooksByYears(int y1, int y2)
        {
            return db.Books.Where(b => b.ReleaseYear >= y1 && b.ReleaseYear <= y2).ToList();
        }
        // ???
        public List<Book> GetBooksByGenreAndDate(string genreTitle, int y1, int y2)
        {
            return db.Books
                .Where(b => b.Genres.Contains(db.Genres.FirstOrDefault(g => g.Title == genreTitle)))
                .Where(b => b.ReleaseYear >= y1 && b.ReleaseYear <= y2)
                .ToList();
        }

        // 2)
        public int GetNumberOfAuthorsBooks(string authorName)
        {
            return db.Authors.FirstOrDefault(a => a.Name == authorName).Books.Count;
        }

        // 3)
        public int GetNumberOfGenresBooks(string genreTitle)
        {
            return db.Genres.FirstOrDefault(g => g.Title == genreTitle).Books.Count;
        }

        // 4)
        public bool IfExistsByAuthorAndTitle(string authorName, string title)
        {
            return db.Books.Any(b => b.Author.Name == authorName && b.Title == title);
        }

        // 5)
        public bool IfUserHas(int id, string title)
        {
            return db.Users.FirstOrDefault(u => u.Id == id).Books.Any(b => b.Title == title);
        }

        // 6)
        public int GetNumberOfUsersBooks(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id).Books.Count;
        }

        // 7)
        public Book GetLastReleasedBook()
        {
            return db.Books.OrderByDescending(b => b.ReleaseYear).FirstOrDefault();
        }

        // 8)
        public List<Book> GetAllBooksSortedByTitle()
        {
            return db.Books.OrderBy(b => b.Title).ToList();
        }

        // 9)
        public List<Book> GetAllBooksSortedByYear()
        {
            return db.Books.OrderByDescending(b => b.ReleaseYear).ToList();
        }
    }
}
