using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.BLL
{
    public class BookService
    {
        BookRepository bookRepository;
        UserRepository userRepository;

        public BookService(AppContext db)
        {
            bookRepository = new BookRepository(db);
            userRepository = new UserRepository(db);
        }


    }
}
