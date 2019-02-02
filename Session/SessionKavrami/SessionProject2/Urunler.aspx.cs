using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionProject2
{
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Urunler"]!=null)
            {
                Dictionary<string, string> gelenData = (Dictionary<string, string>)Session["Urunler"];

                foreach(var item in gelenData)
                {
                    ltrUrunler.Text += "<a href='Detay.aspx?Id=" + item.Value + "'><h1 style='color:red'>" + item.Key + "<i>(" + item.Value + ")</i></h1></a>";
                }
            }
        }
    }
}