using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//
using System.Configuration;
//

namespace Medicare.User
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\medicare.mdf;Integrated Security=True");
        int tot = 0;
        //
      
        DataSet ds = new DataSet();

        //

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("resist.aspx");
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from regist where email='" + em.Text + "' and password='" + pwd.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
           

            tot = Convert.ToInt32(dt.Rows.Count.ToString());
            if (tot > 0)
            {
               
                    Session["user"] = em.Text;
                  
                
                    Response.Redirect("Home.aspx");
                    //Label1.Visible = true;
                
               
            }
            else
            {
                Label1.Text = "Invalid Email or Password";
                Session["user"] = null;
            }

            con.Close();
            }
            catch (SqlException)
            {
                Label1.Text = "Database Connection failed";
            }
        }
    }
}