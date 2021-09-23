 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Kategoriler : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string kategoriId="";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            kategoriId = Request.QueryString["KategoriID"];
            islem = Request.QueryString["islem"];
        }

        SqlCommand com = new SqlCommand("Select * from TBLKATEGORI", bgl.baglanti());
        SqlDataReader da = com.ExecuteReader();
        DataList1.DataSource = da;
        DataList1.DataBind();

        if (islem=="sil")
        {
            SqlCommand sil =new SqlCommand("Delete from TBLKATEGORI where KategoriID=@p1",bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", kategoriId);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
        }


        Panel2.Visible = false;
        Panel4.Visible = false;
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
        Panel4.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Insert Into TBLKATEGORI (KategoriAd, KategoriResim) values (@p1,@p2)",bgl.baglanti());
        com.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
        com.Parameters.AddWithValue("@p2", FileUpload1.FileName);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();
        
    }
}