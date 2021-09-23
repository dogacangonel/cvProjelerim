using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class KategoriDuzenle : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string kategoriID = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        kategoriID = Request.QueryString["KategoriID"];

        if (Page.IsPostBack == false)
        {
            SqlCommand com = new SqlCommand("Select * from TBLKATEGORI where KategoriID=@p1", bgl.baglanti());
            com.Parameters.AddWithValue("@p1", Convert.ToInt32(kategoriID));
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                TextBox1.Text = da[1].ToString();
                TextBox2.Text = da[2].ToString();
            }
            bgl.baglanti().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Update TBLKATEGORI set KategoriAd=@p1,KategoriAdet=@p2 where KategoriID=@p3", bgl.baglanti());
        com.Parameters.AddWithValue("@p1", TextBox1.Text);
        com.Parameters.AddWithValue("@p2", TextBox2.Text);
        com.Parameters.AddWithValue("@p3", kategoriID);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}