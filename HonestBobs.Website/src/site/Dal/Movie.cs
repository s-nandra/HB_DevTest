using System.ComponentModel.DataAnnotations;

namespace HonestBobs.Website.Dal
{
    public class Movie
    {
        [ScaffoldColumn(false)]
        public int MovieID { get; set; }

        [Required, StringLength(150), Display(Name = "Name")]
        public string MovieName { get; set; }

        [Required, StringLength(250), Display(Name = "Description"), DataType(DataType.MultilineText)]
        public string MovieDescription { get; set; }

        [Display(Name = "Price")]
        public double? MoviePrice { get; set; }

        [Required, StringLength(150), Display(Name = "Format")]
        public string Format { get; set; }

        [Required, StringLength(250), Display(Name = "Studio")]
        public string Studio { get; set; }

        public int? Disc { get; set; }
 
        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public bool IsActive { get; set; }
    }
}