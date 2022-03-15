using Module25EF.DAL_and_BLL.Models;
using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views.AdminViews
{
    public class BookAddingView
    {
        BookRepository bookRepository;

        public BookAddingView(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void Show()
        {
            try
            {
                Console.WriteLine("Введите название книги:");
                string title = Console.ReadLine();
                Console.WriteLine("Введите имя автора:");
                var author = GetAuthor();
                Console.WriteLine("Введите год выпуска:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите жанр книги:");
                var genre = GetGenre();

                bookRepository.AddBook(new Book { Title = title, Author = author, ReleaseYear = year, Cost = cost, Genre = genre }, author, genre);
                Message.Green("Книга добавлена!");
            }
            catch
            {
                Message.Red("Введено значение неверного формата!");
            }
        }

        public Author GetAuthor()
        {
            while (true)
            {
                string authorName = Console.ReadLine();
                if(authorName != "")
                {
                    if (bookRepository.GetAuthorByName(authorName) != null)
                        return bookRepository.GetAuthorByName(authorName);
                    else
                        return new Author { Name = authorName };
                }
                else
                    Message.Red("Введено значение неверного формата! Повторите ввод");
            }
        }
        public Genre GetGenre()
        {
            while (true)
            {
                string genreTitle = Console.ReadLine();
                if(genreTitle != "")
                {
                    if (bookRepository.GetGenreByTitle(genreTitle) != null)
                        return bookRepository.GetGenreByTitle(genreTitle);
                    else
                        return new Genre { Title = genreTitle };
                }
                else
                    Message.Red("Введено значение неверного формата! Повторите ввод");
            }
        }
    }
}
