using HonestBobs.Website.Dal;
using System;
using System.Linq;
using System.Web.UI;

namespace HonestBobs.Website
{
    public partial class _default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new HBContext();
            IQueryable<Category> query = _db.Categories
                .Where(x => x.IsActive == true); 
            return query;
        }
    }
}