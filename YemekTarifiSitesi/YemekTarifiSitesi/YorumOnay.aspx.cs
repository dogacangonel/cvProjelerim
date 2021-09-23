using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class KategoriOnay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string yorumId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        yorumId = Request.QueryString["YorumID"];

        if (Page.IsPostBack == false)
        {
            SqlCommand com = new SqlCommand("Select YorumAdSoyad,YorumMail,YorumIcerik,YemekAd from TBLYORUMLAR" +
                " inner join TBLYEMEKLER on TBLYORUMLAR.YorumID=TBLYEMEKLER.YemekID  where YorumID=@p1", bgl.baglanti());
            com.Parameters.AddWithValue("@p1", Convert.ToInt32(yorumId));
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                txtAdSoyad.Text = da[0].ToString();
                txtMail.Text = da[1].ToString();
                txtIcerik.Text = da[2].ToString();
                txtYemek.Text = da[3].ToString();
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Update TBLYORUMLAR set YorumAdSoyad=@p1,YorumMail=@p2,YorumOnay=@p3,YorumIcerik=@p4 where YorumID=@p5",bgl.baglanti());
        com.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
        com.Parameters.AddWithValue("@p2", txtMail.Text);
        com.Parameters.AddWithValue("@p3","True");
        com.Parameters.AddWithValue("@p4", txtIcerik.Text);
        com.Parameters.AddWithValue("@p5", Convert.ToInt32(yorumId));
        com.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}