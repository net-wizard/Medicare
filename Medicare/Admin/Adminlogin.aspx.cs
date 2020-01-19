using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Medicare.Admin
{
    public partial class Adminlogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\medicare.mdf;Integrated Security=True");
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from adminlogin where username='"+txtemail.Text+"' and passwd='"+txtpassword.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if(i==1)
            {
                Session["admin"] = txtemail.Text;
                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                Label1.Text = "You have entered invalid username or password";
            }

            con.Close();
        }
    }
}