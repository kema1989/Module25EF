using Module25EF.DAL_and_BLL.Models;
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

        public void AddBook(Book book, Author author, Genre genre)
        {
            db.Books.Add(book);
            if(GetAuthorByName(author.Name) != null)
                db.Authors.FirstOrDefault(a => a == author).Books.Add(book);
            if(GetGenreByTitle(genre.Title) != null)
                db.Genres.FirstOrDefault(g => g == genre).Books.Add(book);
            db.SaveChanges();
        }

        public Author GetAuthorByName(string name)
        {
            return db.Authors.FirstOrDefault(a => a.Name == name);
        }

        public Genre GetGenreByTitle(string title)
        {
            return db.Genres.FirstOrDefault(g => g.Title == title);
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

        public void AddAuthor(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }

        public void DeleteAuthor(Author author)
        {
            db.Books.RemoveRange(db.Books.Where(b => b.Author == author));
            db.Authors.Remove(author);
            db.SaveChanges();
        }

        public void AddGenre(Genre genre)
        {
            db.Genres.Add(genre);
            db.SaveChanges();
        }

        public void DeleteGenre(Genre genre)
        {
            db.Books.RemoveRange(db.Books.Where(b => b.Genre == genre));
            db.Genres.Remove(genre);
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
