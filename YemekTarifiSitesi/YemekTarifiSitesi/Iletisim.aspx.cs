using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Iletisim : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGonder_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Insert Into TBLYORUMLAR (mesajGonderen,mesajMail,MesajBaslik,mesajIcerik) values(@p1,@p2,@p3,@p4)");
        com.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
        com.Parameters.AddWithValue("@p2", txtMailAdres.Text);
        com.Parameters.AddWithValue("@p1", txtKonu.Text);
        com.Parameters.AddWithValue("@p1", txtMesaj.Text);
        com.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}