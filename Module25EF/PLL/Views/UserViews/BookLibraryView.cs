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
                        if (bookRepository.GetAllBooksSortedByTitle().Count == 0)
                            Message.Blue("Пусто...");
                        else
                        {
                            bookRepository.GetAllBooksSortedByTitle().ForEach(b =>
                            {
                                Console.WriteLine($"<<Id: {b.Id}, Название: {b.Title}, Автор: {b.Author.Name},\nГод выпуска: {b.ReleaseYear}, Жанр: {b.Genre.Title}, Стоимость: {b.Cost}>>");
                            });
                        }
                        break;
                    case "2":
                        if (bookRepository.GetAllBooksSortedByYear().Count == 0)
                            Message.Blue("Пусто...");
                        else
                        {
                            bookRepository.GetAllBooksSortedByYear().ForEach(b =>
                            {
                                Console.WriteLine($"<<Id: {b.Id}, Название: {b.Title}, Автор: {b.Author.Name},\nГод выпуска: {b.ReleaseYear}, Жанр: {b.Genre.Title}, Стоимость: {b.Cost}>>");
                            });
                        }
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
