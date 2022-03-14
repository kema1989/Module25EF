using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF
{
    public class AuthenticationView
    {
        public void Show()
        {
            Console.WriteLine("Войти в профиль (нажмите 1)");
            Console.WriteLine("Зарегистрироваться (нажмите 2)");
            Console.WriteLine("Выйти (нажмите 0)");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Program.userAuthenticationView.Show();
                        break;
                    case "2":
                        Program.registrationView.Show();
                        break;
                    case "0":
                        Program.mainView.Show();
                        break;
                    default:
                        Console.WriteLine("Введено значение неверного формата!");
                        break;
                }
            }
        }
    }
}
