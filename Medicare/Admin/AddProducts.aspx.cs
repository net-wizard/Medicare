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
    public partial class AddPrescribed : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\medicare.mdf;Integrated Security=True");
        String a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            a = Class1.GetRandomPassword(10).ToString();
            f1.SaveAs(Request.PhysicalApplicationPath + "./PImage/" + a + f1.FileName.ToString());
            b = "../PImage/" + a + f1.FileName.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into product values('" + tn.Text + "','" + td.Text + "'," + tp.Text + "," + tq.Text + ",'" + b.ToString() + "','" + cat.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            l1.Text = "Successfully Inserted";
        }
    }
}