using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views
{
    public class UserView
    {
        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Просмотреть список приобретенных книг (нажмите 1)");
                Console.WriteLine("Просмотреть каталог книг (нажмите 2)");
                Console.WriteLine("Посмотреть рекламу (и заработать денег!) (нажмите 3)");
                Console.WriteLine("Выйти в главное меню (нажмите 0)");

                string keyValue = Console.ReadLine();

                if (keyValue == "0") break;

                switch (keyValue)
                {
                    case "1":
                        Program.userBooksView.Show(user);
                        break;
                    case "2":
                        Program.bookLibraryView.Show(user);
                        break;
                    case "3":
                        AnnoyingAdvertisement.Show(user);
                        break;
                }

            }
        }
    }
}
