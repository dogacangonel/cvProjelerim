using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class User : System.Web.UI.MasterPage
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("Select * from TBLKATEGORI", bgl.baglanti());
        SqlDataReader read = com.ExecuteReader();
        DataList1.DataSource = read;
        DataList1.DataBind();

    }
}
