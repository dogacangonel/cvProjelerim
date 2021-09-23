using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> list = BLLOgrenci.BLLListele();
        Repeater1.DataSource = list;
        Repeater1.DataBind();
    }
}