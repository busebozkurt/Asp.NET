using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserName"]!=null)
            {
                Response.Redirect("Profile.aspx");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session.Add("UserName", txtKulAdi.Text);
            Session.Timeout = 45;
            Response.Redirect("Profile.aspx");
        }
    }
}