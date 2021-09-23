﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Mesajlar : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        SqlCommand com = new SqlCommand("Select * from TBLMESAJLAR", bgl.baglanti());
        SqlDataReader da = com.ExecuteReader();
        DataList1.DataSource = da;
        DataList1.DataBind();
    }



    protected void Button1_Click1(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }
}