using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class TarifOner : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTarifOner_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Insert Into TBLTARIFLER (TarifAd,TarifMalzeme,TarifYapilis,TarifResim,TarifSahibi,TarifSahibiMail) values (@t1,@t2,@t3,@t4,@t5,@t6)",bgl.baglanti());
        com.Parameters.AddWithValue("@t1",txtTarifAd.Text);        
        com.Parameters.AddWithValue("@t2",txtMalzemeler.Text);        
        com.Parameters.AddWithValue("@t3",txtYapilis.Text);        
        com.Parameters.AddWithValue("@t4",FileUpload1.FileName);        
        com.Parameters.AddWithValue("@t5",txtTarifOneren.Text);        
        com.Parameters.AddWithValue("@t6",txtMail.Text);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();
        Response.Write("Tarifiniz gönderildi...");
    }
}