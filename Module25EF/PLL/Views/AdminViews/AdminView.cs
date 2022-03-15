using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL
{
    public class AdminView
    {
        UserRepository userRepository;
        BookRepository bookRepository;
        public AdminView(UserRepository userRepository, BookRepository bookRepository)
        {
            this.userRepository = userRepository;
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Добавить книгу (нажмите 1)");
                Console.WriteLine("Удалить книгу (нажмите 2)");
                Console.WriteLine("Показать все книги (нажмите 3)");
                Console.WriteLine("Добавить пользователя (нажмите 4)");
                Console.WriteLine("Удалить пользователя (нажмите 5)");
                Console.WriteLine("Показать всех пользователей (нажмите 6)");
                Message.Red("Выйти (нажмите 0)");

                switch (Console.ReadLine())
                {
                    case "1":
                        Program.bookAddingView.Show();
                        break;
                    case "2":
                        DeleteBook();
                        break;
                    case "3":
                        if (bookRepository.GetAllBooksSortedByTitle().Count == 0)
                            Message.Blue("Пусто...");
                        else
                        {
                            bookRepository.GetAllBooksSortedByTitle().ForEach(b =>
                            {
                                Console.WriteLine($"<<Id: {b.Id}, Название: {b.Title}, Автор: {b.Author.Name},\nГод выпуска: {b.ReleaseYear}, Жанр: {b.Genre.Title}, Стоимость: {b.Cost}>>");
                            });
                        }
                        break;
                    case "4":
                        Program.registrationView.Show();
                        break;
                    case "5":
                        DeleteUser();
                        break;
                    case "6":
                        if (userRepository.GetAllUsers().Count == 0)
                            Message.Blue("Пусто...");
                        else
                        {
                            userRepository.GetAllUsers().ForEach(u =>
                            {
                                Console.WriteLine($"Id: {u.Id}, Имя: {u.Name}, Email: {u.Email}");
                            });
                        }
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            }
        }

        public void DeleteBook()
        {
            try
            {
                Console.WriteLine("Введите Id книги:");
                var id = Convert.ToInt32(Console.ReadLine());
                bookRepository.Delete(bookRepository.GetBookById(id));
                Message.Green("Удаление выполнено успешно!");
            }
            catch
            {
                Message.Red("Введено значение неверного формата!");
            }
        }

        public void DeleteUser()
        {
            try
            {
                Console.WriteLine("Введите Id пользователя:");
                var id = Convert.ToInt32(Console.ReadLine());
                userRepository.Delete(userRepository.GetUserById(id));
                Message.Green("Удаление выполнено успешно!");
            }
            catch
            {
                Message.Red("Введено значение неверного формата!");
            }
        }
    }
}
