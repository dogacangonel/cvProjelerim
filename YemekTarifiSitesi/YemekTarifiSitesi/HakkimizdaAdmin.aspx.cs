using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class HakkimizdaAdmin : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;

        if (Page.IsPostBack == false)
        {
            SqlCommand com = new SqlCommand("Select * From TBLHAKKIMIZDA", bgl.baglanti());
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                TextBox1.Text = da[0].ToString();
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("update TBLHAKKIMIZDA set metin=@p1");
        com.Parameters.AddWithValue("@p1", TextBox1.Text);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}