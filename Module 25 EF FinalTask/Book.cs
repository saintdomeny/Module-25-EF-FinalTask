using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_25_EF_FinalTask
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? PublishYear { get; set; }


        public int? UserId { get; set; }// несколько разных книг может быть выдано одному пользователю, но одна книга может быть только у одного пользователя
        public User? User { get; set; }

        public int? AuthorId { get; set; }
        public Author? Author { get; set; }

        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Book>? Books { get; set; } = new List<Book>();
    }

    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Book>? Books { get; set; } = new List<Book>();
    }
}
