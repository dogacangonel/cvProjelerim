using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


public partial class DersListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            DropDownList1.DataSource = BLLDersler.ListeleBLL();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvuruForm ent = new EntityBasvuruForm();
        ent.BASOGRENCIID =Convert.ToInt32(txtId.Text);
        ent.BASDERSID =Convert.ToInt32( DropDownList1.SelectedValue);
        BLLDersler.TalepEkleBLL(ent);
    }
}