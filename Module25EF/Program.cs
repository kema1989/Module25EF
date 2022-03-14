using Module25EF.BLL;
using Module25EF.PLL;
using Module25EF.PLL.Helpers;
using Module25EF.PLL.Views;
using Module25EF.PLL.Views.UserViews;
using System;

namespace Module25EF
{
    class Program
    {
        static UserRepository userRepository;
        static BookRepository bookRepository;

        public static MainView mainView;

        public static AuthenticationView authenticationView;
        public static UserAuthenticationView userAuthenticationView;
        public static RegistrationView registrationView;
        public static UserView userView;
        public static UserBooksView userBooksView;
        public static BookLibraryView bookLibraryView;
        public static BookBuyingView bookBuyingView;

        public static AdminAuthenticationView adminAuthenticationView;
        public static AdminView adminView;


        static void Main(string[] args)
        {
            userRepository = new UserRepository();
            bookRepository = new BookRepository();
            
            mainView = new MainView();
            authenticationView = new AuthenticationView();
            userAuthenticationView = new UserAuthenticationView(userRepository);
            registrationView = new RegistrationView(userRepository);
            userView = new UserView();
            userBooksView = new UserBooksView();
            bookLibraryView = new BookLibraryView(bookRepository);
            bookBuyingView = new BookBuyingView(userRepository, bookRepository);

            adminAuthenticationView = new AdminAuthenticationView();
            adminView = new AdminView();


            while (true)
            {
                mainView.Show();
            }
        }
    }
}
