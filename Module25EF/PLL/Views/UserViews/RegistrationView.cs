using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF
{
    public class RegistrationView
    {
        UserRepository userRepository;
        public RegistrationView(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Введите имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите email:");
                string email = Console.ReadLine();
                Console.WriteLine("Введите пароль (не менее 8 знаков):");
                string password = Console.ReadLine();
                
                if(name == "" || email == "" || password == "")
                {
                    Console.WriteLine("Введено пустое поле!");
                    break;
                }
                if (!new EmailAddressAttribute().IsValid(email))
                {
                    Console.WriteLine("Введен email неверного формата!");
                    break;
                }
                if (userRepository.GetUserByEmail(email) != null)
                {
                    Console.WriteLine("Данный email занят!");
                    break;
                }
                if (password.Length < 8)
                {
                    Console.WriteLine("Пароль должен быть не короче 8 знаков");
                    break;
                }

                userRepository.Add(new User { Name = name, Email = email, Password = password });
                return;
            }
        }
    }
}
