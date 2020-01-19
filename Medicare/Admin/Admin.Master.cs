using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medicare.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Adminlogin.aspx");
            }
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("../User/Home.aspx");
        }
    }
}