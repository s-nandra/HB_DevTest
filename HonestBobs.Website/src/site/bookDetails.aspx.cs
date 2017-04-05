using HonestBobs.Website.Dal;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace HonestBobs.Website
{
    public partial class bookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public IQueryable<Book> GetBooks()
        {

            var _db = new HBContext();
            IQueryable<Book> query = _db.Books
                .Where(b => b.IsActive == true);

            try
            {
                // int try parse / error handling
                var bookId = Convert.ToInt32(Request.QueryString["BookID"]);

                if (bookId > 0)
                {
                    query = query.Where(p => p.BookID == bookId);
                }
            }
            catch { }

            return query;

        }



    }
}