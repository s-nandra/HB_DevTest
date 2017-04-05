using System.ComponentModel.DataAnnotations;

namespace HonestBobs.Website.Dal
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int BookID { get; set; }

        [Required, StringLength(150), Display(Name = "Name")]
        public string BookName { get; set; }

        [Required, StringLength(5000), Display(Name = "Description"), DataType(DataType.MultilineText)]
        public string BookDescription { get; set; }

        [Display(Name = "Price")]
        public double? BookPrice { get; set; }

        [Required, StringLength(150), Display(Name = "Author")]
        public string Author { get; set; }

        [Required, StringLength(20), Display(Name = "ISBN")]
        public string ISBN { get; set; }

        public int? PageCount { get; set; }
 

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public bool IsActive { get; set; }
    }
}