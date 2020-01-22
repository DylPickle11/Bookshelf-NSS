using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }
    }
}
