using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace search
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);




            SqlCommand cmd = new SqlCommand("select * from search1 where name ='" + TextBox1.Text + "'", con);


            SqlDataAdapter adpt = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();


            con.Open(); adpt.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt; GridView1.DataBind();


                msg.Text = "Record Founded!";


            }
            else { msg.Text = "Record Not Founded!"; }


        }
    }
    }
