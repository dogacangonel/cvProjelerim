using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class KategoriDetay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string kategoriDetay = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        kategoriDetay = Request.QueryString["KategoriID"];

        SqlCommand com = new SqlCommand("select * from TBLYEMEKLER where Kategori=@p1",bgl.baglanti());
        com.Parameters.AddWithValue("@p1",Convert.ToInt32(kategoriDetay));
        SqlDataReader da = com.ExecuteReader();
        DataList2.DataSource = da;
        DataList2.DataBind();


    }
}