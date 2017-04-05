using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HonestBobs.Website.Dal
{
    public class HBContext: DbContext
	{
		public HBContext() : base("HonestBobs")
		{
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}