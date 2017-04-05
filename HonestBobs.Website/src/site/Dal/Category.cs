using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HonestBobs.Website.Dal
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(50), Display(Name = "Categories")]
        public string CategoryName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public bool IsActive { get; set; }
    }
}