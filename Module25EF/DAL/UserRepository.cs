using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF
{
    public class UserRepository
    {
        private AppContext db;
        public UserRepository(AppContext db)
        {
            this.db = db;
        }
        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }

        public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Delete(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public void UpdateById(int id)
        {
            db.Users.FirstOrDefault(u => u.Id == id).Name = Console.ReadLine();
            db.SaveChanges();
        }

        public void AddABook(Book book)
        {
            
        }
    }
}
