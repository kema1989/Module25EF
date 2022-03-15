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
                string authorName = Console.ReadLine();
                var author = bookRepository.Ge
                Console.WriteLine("Введите год выпуска:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите жанры книги");
                var genres = GetGenres();

                if (title == "" || author == "")
                    Console.WriteLine("Одно из полей пустое!");

                bookRepository.AddBook(new Book { Title = title, Author = author, ReleaseYear = year, Cost = cost, Genres = genres });
            }
            catch
            {
                Console.WriteLine("Введено значение неверного формата!");
            }
        }

        public List<string> GetGenres()
        {
            Console.WriteLine("Можно добавить до 5 жанров, для завершения добавления введите 0");
            var genres = new List<string>();
            while (true)
            {
                var genre = Console.ReadLine();
                if(genre == "0")
                {
                    if (genres.Count > 0)
                        return genres;
                    else
                        Console.WriteLine("Не добавлен ни один жанр");
                }
                if (genres.Count == 5)
                    return genres;
                genres.Add(genre);
            }
        }
    }
}
