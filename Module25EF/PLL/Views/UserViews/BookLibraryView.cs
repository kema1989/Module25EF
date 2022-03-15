using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views.UserViews
{
    public class BookLibraryView
    {
        BookRepository bookRepository;
        public BookLibraryView(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Показать все книги в порядке А-Я по названию (нажмите 1)");
                Console.WriteLine("Показать все книги в порядке по году выпуска (нажмите 2)");
                Message.Blue("Купить книгу (нажмите 3)");
                Message.Red("Выйти (нажмите 0)");

                switch (Console.ReadLine())
                {
                    case "1":
                        bookRepository.GetAllBooksSortedByTitle().ForEach(b =>
                        {
                            Console.WriteLine($"Id: {b.Id}, Название: {b.Title}, Автор: {b.Author}, Год выпуска: {b.ReleaseYear},\n, Стоимость: {b.Cost}");
                            Console.Write("Жанр: ");
                            b.Genres.ForEach(g => Console.Write(g));
                        });
                        break;
                    case "2":
                        bookRepository.GetAllBooksSortedByYear().ForEach(b =>
                        {
                            Console.WriteLine($"Id: {b.Id}, Название: {b.Title}, Автор: {b.Author}, Год выпуска: {b.ReleaseYear},\n, Стоимость: {b.Cost}");
                            Console.Write("Жанр: ");
                            b.Genres.ForEach(g => Console.Write(g));
                        });
                        break;
                    case "3":
                        Program.bookBuyingView.Show(user);
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}
