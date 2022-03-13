using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.BLL
{
    public class UserService
    {
        UserRepository userRepository; 
        BookService bookService;
        AppContext db;

        public UserService(AppContext db)
        {
            userRepository = new UserRepository(db);
            bookService = new BookService(db);
        }

        public void Register()
        {

        }

    }
}
