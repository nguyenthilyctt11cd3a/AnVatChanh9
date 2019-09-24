using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnVatChanh9.Models;
using AnVatChanh9.Logic;
namespace AnVatChanh9
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                string cartStr = string.Format("Giỏ hàng ({0})",
                usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new AnVatChanh9.Models.BookContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

    }
}