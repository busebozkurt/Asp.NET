using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionProject
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                lblInfo.Text = "Merhaba" + Session["UserName"] + "; Hoşgeldin";
            }
        }
        protected void btnBeniUnut_Click(object sender,EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

    }
}