using System;

namespace Module25EF
{
    class Program
    {
        public static MainView mainView;
        public static AuthenticationView authenticationView;
        public static RegistrationView registrationView;


        static void Main(string[] args)
        {
            using(var db = new AppContext())
            {

            }
        }
    }
}
