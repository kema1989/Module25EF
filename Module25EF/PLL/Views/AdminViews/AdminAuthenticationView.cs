using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views
{
    public class AdminAuthenticationView
    {
        public void Show()
        {
            Console.WriteLine("Введите пароль:"); // Лень было возиться с ролью админа))
            string password = Console.ReadLine();
            if (password == "12345678")
            {
                Message.Green("Вы успешно вошли как администратор");
                Program.adminView.Show();
            }
            else
            {
                Message.Red("Неверный пароль!");
            }

        }
    }
}
