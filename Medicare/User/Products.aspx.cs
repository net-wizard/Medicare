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
    public partial class Products : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\medicare.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();
            con.Close();
            }
        }
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
           // Server.Transfer("ProductDesc.aspx?id=");
        }

        protected void d1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName=="clk")
            {
                Server.Transfer("ProductDesc.aspx?id=" + e.CommandArgument.ToString());
            }
        }

    }
}