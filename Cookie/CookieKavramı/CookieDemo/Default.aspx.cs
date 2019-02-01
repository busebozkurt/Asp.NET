using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlUrunler.Items.Add(new ListItem { Text = "Urun1", Value = "1" });
                ddlUrunler.Items.Add(new ListItem { Text = "Urun2", Value = "2" });
            }
        }
        protected void ddlUrunler_SelectedIndexChanged(object sender,EventArgs e)
        {
            HttpCookie httpCookie;
            if(Request.Cookies["Stok"]==null)
            {
                httpCookie = new HttpCookie("Stok");
                httpCookie[ddlUrunler.SelectedItem.Value] = "1";
                httpCookie.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(httpCookie);
            }
            else
            {
                httpCookie = Request.Cookies["Stok"];
            
                int value = int.Parse(httpCookie[ddlUrunler.SelectedItem.Value]); ;
                value++;
                httpCookie[ddlUrunler.SelectedItem.Value] = value.ToString(); 
                Response.Cookies.Add(httpCookie);
            }
            Response.Write(httpCookie[ddlUrunler.SelectedItem.Value]);
        }
    }
}