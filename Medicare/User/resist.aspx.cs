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
    public partial class resist : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\medicare.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
           

        }

        protected void b1_Click1(object sender, EventArgs e)
        {
            if (checkemail() == true)
            {
                l1.Text = "Your Email Already Registered with Us";
                em.BackColor = System.Drawing.Color.Red;


            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into regist values('" + fn.Text + "','" + ln.Text + "','" + em.Text + "','" + pwd.Text + "','" + addr.Text + "','" + cty.Text + "','" + st.Text + "','" + pin.Text + "','" + mn.Text + "')";
                cmd.ExecuteNonQuery();

                fn.Text = "";
                ln.Text = "";
                em.Text = "";
                pwd.Text = "";
                addr.Text = "";
                cty.Text = "";
                st.Text = "";
                pin.Text = "";
                mn.Text = "";

                l1.Text = "Resisteration Succesfull";

                con.Close();
            }
        }

        private Boolean checkemail()
        {
            Boolean emailavailable = false;
           
            String myquery = "Select * from regist where email='" + em.Text + "'";
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                emailavailable = true;

            }
            con.Close();

            return emailavailable;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}