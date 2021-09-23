using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Yemekler : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string yemekId = "";
    string silme = "";
    string kategori = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            yemekId = Request.QueryString["YemekID"];
            silme = Request.QueryString["silme"];
            kategori = Request.QueryString["Kategori"];
        }

        SqlCommand com = new SqlCommand("Select * from TBLYEMEKLER", bgl.baglanti());
        SqlDataReader da = com.ExecuteReader();
        DataList1.DataSource = da;
        DataList1.DataBind();

        Panel2.Visible = false;
        Panel4.Visible = false;

        if (Page.IsPostBack == false)
        {
            SqlCommand com2 = new SqlCommand("Select * from TBLKATEGORI", bgl.baglanti());
            SqlDataReader da2 = com2.ExecuteReader();

            DropDownList1.DataTextField = "KategoriAd";
            DropDownList1.DataValueField = "KategoriID";

            DropDownList1.DataSource = da2;
            DropDownList1.DataBind();
        }

        if (silme=="sil")
        {
           
            //Silme İşlemi

            SqlCommand com3 = new SqlCommand("Delete from TBLYEMEKLER where YemekID=@p1",bgl.baglanti());
            com3.Parameters.AddWithValue("@p1", Convert.ToInt32(yemekId));
            com3.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Kategori Eksiltme İşlemi

            SqlCommand com4 = new SqlCommand("Update TBLKATEGORI set KategoriAdet=KategoriAdet-1 where KategoriID=@p1", bgl.baglanti());
            com4.Parameters.AddWithValue("@p1", Convert.ToInt32(kategori));
            com4.ExecuteNonQuery();
            bgl.baglanti().Close();

        }


    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        Panel2.Visible = false;

    }

    protected void Button3_Click1(object sender, EventArgs e)
    {
        Panel4.Visible = true;

    }

    protected void Button4_Click1(object sender, EventArgs e)
    {
        Panel4.Visible = false;

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        // Yemek Ekle
        SqlCommand com = new SqlCommand("Insert Into TBLYEMEKLER (YemekAd,YemekMalzeme,YemekTarif,YemekResim,Kategori) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
        com.Parameters.AddWithValue("@p1", txtYemekAd.Text);
        com.Parameters.AddWithValue("@p2", txtMalzeme.Text);
        com.Parameters.AddWithValue("@p3", txtTarif.Text);
        com.Parameters.AddWithValue("@p4", FileUpload2.FileName);
        com.Parameters.AddWithValue("@p5", DropDownList1.SelectedValue);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();

        //Kategori Adeti Ekleme
        SqlCommand com2 = new SqlCommand("Update TBLKATEGORI set KategoriAdet=KategoriAdet+1 where KategoriID=@p1", bgl.baglanti());
        com2.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
        com2.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}