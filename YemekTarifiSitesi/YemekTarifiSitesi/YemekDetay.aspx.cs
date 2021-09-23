using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemekDetay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string yemekid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        yemekid = Request.QueryString["YemekID"]; // soru işaretinden sonra taşımış olduğum değeri burada atamam yarayan komut dizisi
        SqlCommand com = new SqlCommand("Select YemekAd from TBLYEMEKLER Where YemekID=@p1 ", bgl.baglanti());
        com.Parameters.AddWithValue("@p1", Convert.ToInt32(yemekid));
        SqlDataReader da = com.ExecuteReader();
        while (da.Read())
        {
            Label3.Text = da[0].ToString();
        }
        bgl.baglanti().Close();

        //Yorumları Listele

        SqlCommand yorumList = new SqlCommand("Select * from TBLYORUMLAR Where Yemek=@p2", bgl.baglanti());
        yorumList.Parameters.AddWithValue("@p2", Convert.ToInt32(yemekid));
        SqlDataReader yorumRead = yorumList.ExecuteReader();
        DataList2.DataSource = yorumRead;
        DataList2.DataBind();
        


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Insert into TBLYORUMLAR (YorumAdSoyad,YorumMail,YorumIcerik,YemekID) values(@p1,@p2,@p3,@p4)",bgl.baglanti());
        com.Parameters.AddWithValue("@p1",txtAdSoyad.Text);
        com.Parameters.AddWithValue("@p2", txtMail.Text);
        com.Parameters.AddWithValue("@p3", txtYorum.Text);
        com.Parameters.AddWithValue("@p4", yemekid);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}