﻿using HonestBobs.Website.Dal;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace HonestBobs.Website
{
    public partial class books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         

        public IQueryable<Book> GetBooks()
        {
            
            var _db = new HBContext();
            IQueryable<Book> query = _db.Books
                .Where(b => b.IsActive == true);

            //var categoryId = Convert.ToInt32(Request.QueryString["id"]);

            //if (categoryId > 0)
            //{
            //    query = query.Where(p => p.CategoryID == categoryId);
            //}
            return query; 
        }

       

    }
}