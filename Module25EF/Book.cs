using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int Cost { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public Author Author { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
    }
}
