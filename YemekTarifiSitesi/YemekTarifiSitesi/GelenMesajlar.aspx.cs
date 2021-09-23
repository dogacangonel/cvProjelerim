using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GelenMesajlar : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string mesajID ="";
    protected void Page_Load(object sender, EventArgs e)
    {
        mesajID = Request.QueryString["mesajID"];

        SqlCommand com = new SqlCommand("Select * from TBLMESAJLAR where mesajID=@p1",bgl.baglanti());
        com.Parameters.AddWithValue("@p1",Convert.ToInt32(mesajID));
        SqlDataReader da = com.ExecuteReader();
        while (da.Read()) 
        {
            txtAdSoyad.Text = da[4].ToString();
            txtBaslik.Text = da[1].ToString();
            txtMail.Text = da[2].ToString();
            txtIcerik.Text = da[3].ToString();
        }

               
    }
}