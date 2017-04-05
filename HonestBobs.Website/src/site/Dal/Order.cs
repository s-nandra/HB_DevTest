using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HonestBobs.Website.Dal
{
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public DateTime OrderDateTime { get; set; }

        public int Qty { get; set; }

        [Display(Name = "Price")]
        public double? Price { get; set; }

        public bool OrderPlaced { get; set; }

         
    }
}