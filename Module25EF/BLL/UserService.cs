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

        public UserService()
        {
        }

        public void Register()
        {

        }

        public User FindByEmail(string email)
        {
            return userRepository.GetUserByEmail(email);
        }

    }
}
