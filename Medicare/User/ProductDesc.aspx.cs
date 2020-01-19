using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Medicare.User
{
    
    public partial class ProductDesc : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\medicare.mdf;Integrated Security=True");
        int id;
       
        protected void Page_Load(object sender, EventArgs e)
        {


           
    
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where pid="+id+"";
                cmd.ExecuteNonQuery();
               
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();

                
                con.Close();
            }
            
           
        }
       

        

       

       }
}