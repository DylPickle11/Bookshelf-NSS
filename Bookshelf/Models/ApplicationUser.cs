using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<Comment> Comments { get; set; } 
    }
}
// Do not put an Id on you Application User it already has Id inherited from Identity User