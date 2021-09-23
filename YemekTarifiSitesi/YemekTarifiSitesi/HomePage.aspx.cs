using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class HomePage : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Select * from TBLYEMEKLER",bgl.baglanti());
        SqlDataReader da = com.ExecuteReader();
        DataList2.DataSource = da;
        DataList2.DataBind();


    }
}