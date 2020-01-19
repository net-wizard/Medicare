using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medicare.User
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] != null)
            {
                
                Butt.Visible = false;
                Butt1.Visible = true;
                
              
            }
            else
            {
                Butt.Visible = true;
                Butt1.Visible = false;
                Response.Redirect("Login.aspx");
              
            }
        }

        protected void Butt_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void Butt1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            
            Response.Redirect(Request.RawUrl);
        }
       

      


    
    }
}