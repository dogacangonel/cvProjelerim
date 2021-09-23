using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class TarifOnayla : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string tarifId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        tarifId = Request.QueryString["TarifID"];

        if (Page.IsPostBack == false)
        {
            SqlCommand com = new SqlCommand("Select * from TBLTARIFLER where TarifID=@p1", bgl.baglanti());
            com.Parameters.AddWithValue("@p1", Convert.ToInt32(tarifId));
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                txtTarifAd.Text = da[1].ToString();
                txtMalzeme.Text = da[2].ToString();
                txtYapilis.Text = da[3].ToString();
                txtOneren.Text = da[5].ToString();
                txtMail.Text = da[6].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand com2 = new SqlCommand("Select * from TBLKATEGORI", bgl.baglanti());
            SqlDataReader da2 = com2.ExecuteReader();

            DropDownList1.DataValueField = "KategoriID";
            DropDownList1.DataTextField = "KategoriAd";

            DropDownList1.DataSource = da2;
            DropDownList1.DataBind();

        }
    }

    protected void btnOnayla_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Update TBLTARIFLER set TarifDurum=1 where TarifID=@p1",bgl.baglanti());
        com.Parameters.AddWithValue("@p1",Convert.ToInt32( tarifId));
        com.ExecuteNonQuery();
        bgl.baglanti().Close();



        SqlCommand com2 = new SqlCommand("Insert Into TBLYEMEKLER (YemekAd,YemekMalzeme,YemekTarif,Kategori) values(@p1,@p2,@p3,@p4)",bgl.baglanti());
        com2.Parameters.AddWithValue("@p1", txtTarifAd.Text);
        com2.Parameters.AddWithValue("@p2", txtMalzeme.Text);
        com2.Parameters.AddWithValue("@p3", txtYapilis.Text);
        com2.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        com2.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}