using Module25EF.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views
{
    public class UserAuthenticationView
    {
        UserService userService;
        public UserAuthenticationView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show()
        {
            Console.WriteLine("Введите email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            var password = Console.ReadLine();

            try
            {
                var user = userService.FindByEmail(email);
                if (user.Password != password)
                {
                    Console.WriteLine("Неверный пароль!");
                }
                else
                {
                    Program.userView.Show(user);
                }
            }
            catch
            {
                Console.WriteLine("Пользователя с таким email не существует!");
            }
        }

    }
}
