using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemekGuncelle : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string yemekId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        yemekId = Request.QueryString["YemekID"];
        if (Page.IsPostBack == false)
        {

            SqlCommand com = new SqlCommand("Select * from TBLYEMEKLER where YemekID=@p1", bgl.baglanti());
            com.Parameters.AddWithValue("@p1", Convert.ToInt32(yemekId));
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                txtYemekAd.Text = da[1].ToString();
                txtMalzeme.Text = da[2].ToString();
                txtTarif.Text = da[3].ToString();

            }
            bgl.baglanti().Close();

            if (Page.IsPostBack == false)
            {
                SqlCommand com2 = new SqlCommand("Select * from TBLKATEGORI", bgl.baglanti());
                SqlDataReader da2 = com2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = da2;
                DropDownList1.DataBind();
            }
        }

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        //Yemek Güncelle
        FileUpload2.SaveAs(Server.MapPath("/resimler/" + FileUpload2.FileName));
        SqlCommand com = new SqlCommand("Update TBLYEMEKLER set YemekAd=@p1,YemekMalzeme=@p2,YemekTarif=@p3, Kategori=@p4, YemekResim=@p6 where YemekID=@p5", bgl.baglanti());
        com.Parameters.AddWithValue("@p1", txtYemekAd.Text);
        com.Parameters.AddWithValue("@p2", txtMalzeme.Text);
        com.Parameters.AddWithValue("@p3", txtTarif.Text);
        com.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        com.Parameters.AddWithValue("@p5", Convert.ToInt32(yemekId));
        com.Parameters.AddWithValue("@p6", "~/resimler/" + FileUpload2.FileName);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Günün Yemeği değerleri False Yapma .Günün Yemeğini Seçmek için...
        SqlCommand com = new SqlCommand("Update TBLYEMEKLER set Durum=0 ", bgl.baglanti());
        com.ExecuteNonQuery();
        bgl.baglanti().Close();


        //Günün Yemeğini Seçme
        SqlCommand com2 = new SqlCommand("Update TBLYEMEKLER set Durum=1 where YemekID=@p1", bgl.baglanti());
        com2.Parameters.AddWithValue("@p1", Convert.ToInt32(yemekId));
        com2.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}