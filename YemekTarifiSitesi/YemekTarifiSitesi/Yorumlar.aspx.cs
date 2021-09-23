using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Yorumlar : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel4.Visible = false;

        SqlCommand com = new SqlCommand("Select * from TBLYORUMLAR Where YorumOnay=1", bgl.baglanti());
        SqlDataReader da = com.ExecuteReader();
        DataList1.DataSource = da;
        DataList1.DataBind();


        SqlCommand com2 = new SqlCommand("Select * from TBLYORUMLAR Where YorumOnay=0", bgl.baglanti());
        SqlDataReader da2 = com2.ExecuteReader();
        DataList2.DataSource = da2;
        DataList2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }
}