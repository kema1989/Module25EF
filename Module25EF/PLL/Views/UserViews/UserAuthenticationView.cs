using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views
{
    public class UserAuthenticationView
    {
        UserRepository userRepository;
        public UserAuthenticationView(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите email:");
            var email = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            var password = Console.ReadLine();

            try
            {
                var user = userRepository.GetUserByEmail(email);
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
