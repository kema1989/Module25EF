using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views.UserViews
{
    public class BookBuyingView
    {
        UserRepository userRepository;
        BookRepository bookRepository;
        public BookBuyingView(UserRepository userRepository, BookRepository bookRepository)
        {
            this.userRepository = userRepository;
            this.bookRepository = bookRepository;
        }
        public void Show(User user)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Для приобретения книги введите ее Id:");
                    var id = Convert.ToInt32(Console.ReadLine());
                    var book = bookRepository.GetBookById(id);
                    if (user.Balance < book.Cost)
                    {
                        Console.WriteLine("Недостаточно средств!");
                        return;
                    }
                    userRepository.BuyABook(user.Id, book);
                }
                catch
                {
                    Console.WriteLine("Книги с таким Id не существует или введено значение неверного формата");
                }
            }
        }
    }
}
