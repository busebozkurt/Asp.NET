using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionKavrami
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSession.Text = Session.SessionID.ToString();
        }
        protected void btnGonder_Click(object sender,EventArgs e)
        {
            Session.Add("KulAdi", "Deneme");
        }
    }
}