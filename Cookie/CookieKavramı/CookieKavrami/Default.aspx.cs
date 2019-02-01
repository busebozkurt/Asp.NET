using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieKavrami
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LoginInfo"] != null)
            {
                HttpCookie gelenCookie = Request.Cookies["LoginInfo"];
                if (gelenCookie.Expires > DateTime.Now)
                {
                    if (gelenCookie["Username"] == "Buse" && gelenCookie["Password"] == "12345")
                    {
                        Response.Redirect("TimeLine.aspx");
                    }
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Buse") && txtPassword.Text.Equals("12345"))
            {
                if (chkRemember.Checked)
                {
                    HttpCookie myCookie = new HttpCookie("LoginInfo");
                    myCookie["Username"] = txtUsername.Text;
                    myCookie["Password"] = txtPassword.Text;
                    myCookie.Expires = DateTime.Now.AddDays(20);
                    Response.Cookies.Add(myCookie);
                }
                Response.Redirect("TimeLine.aspx");
            }
            else
            {
                Label1.Text = "Hatalı Giriş Yaptınız";
            }
        }

    }
}