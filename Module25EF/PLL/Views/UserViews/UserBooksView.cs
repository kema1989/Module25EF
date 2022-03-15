using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views.UserViews
{
    public class UserBooksView
    {

        public void Show(User user)
        {
            Message.Blue("Ваши книги:");
            user.Books.ForEach(b =>
            {
                Console.WriteLine($"Id: {b.Id}, Название: {b.Title}, Автор: {b.Author}, Год выпуска: {b.ReleaseYear},\n, Стоимость: {b.Cost}");
                Console.Write("Жанр: ");
                b.Genres.ForEach(g => Console.Write(g));
            });
        }
    }
}
