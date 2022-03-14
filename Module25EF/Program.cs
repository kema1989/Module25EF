using Module25EF.BLL;
using Module25EF.PLL;
using Module25EF.PLL.Helpers;
using Module25EF.PLL.Views;
using System;

namespace Module25EF
{
    class Program
    {
        static UserService userService;
        static BookService bookService;

        public static MainView mainView;
        public static AuthenticationView authenticationView;
        public static UserAuthenticationView userAuthenticationView;
        public static RegistrationView registrationView;
        public static AdminAuthenticationView adminAuthenticationView;
        public static UserView userView;
        public static AdminView adminView;


        static void Main(string[] args)
        {
            userService = new UserService();
            bookService = new BookService();
            
            mainView = new MainView();
            registrationView = new RegistrationView(userService);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
