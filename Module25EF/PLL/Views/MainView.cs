using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF
{
    public class MainView
    {
        public void Show()
        {
            Message.Green("Здравствуйте, рады вас видеть!");
            Console.WriteLine("Войти в профиль (нажмите 1)");
            Console.WriteLine("Впервые здесь? Зарегистрируйтесь (нажмите 2)");
            Message.Red("Выйти (нажмите 3)");

            switch (Console.ReadLine())
            {
                case "1":
                    Program.authenticationView.Show();
                    break;
                case "2":
                    Program.registrationView.Show();
                    break;
                case "3":
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
