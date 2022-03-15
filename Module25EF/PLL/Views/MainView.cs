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
            Message.Green("Здравствуйте, вас приветствует E-Library!");
            Console.WriteLine("Войти как читатель (нажмите 1)");
            Console.WriteLine("Войти как администратор (нажмите 2)");
            Message.Red("Выйти (нажмите 0)");

            switch (Console.ReadLine())
            {
                case "1":
                    Program.authenticationView.Show();
                    break;
                case "2":
                    Program.adminAuthenticationView.Show();
                    break;
                case "0":
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
