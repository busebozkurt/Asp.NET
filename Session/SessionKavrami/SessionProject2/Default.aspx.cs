using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionProject2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Iphone 6", "1");
            dictionary.Add("Iphone 7", "2");
            dictionary.Add("Iphone 8", "3");
            dictionary.Add("Iphone X", "4");

            Session.Add("Urunler", dictionary);
            Response.Redirect("Urunler.aspx");
        }
    }
}