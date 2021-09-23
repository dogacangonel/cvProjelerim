using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;



public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            int id = Convert.ToInt32(Request.QueryString["ogrId"]);
            txtId.Text = id.ToString();
            txtId.Enabled = false;

            List<EntityOgrenci> list = BLLOgrenci.BLLOgrenciDetay(id);
            txtAd.Text = list[0].AD.ToString();
            txtSoyad.Text = list[0].SOYAD.ToString();
            txtNumara.Text = list[0].NUMARA.ToString();
            txtFotograf.Text = list[0].FOTOGRAF.ToString();
            txtSifre.Text = list[0].SIFRE.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = txtAd.Text;
        ent.SOYAD = txtSoyad.Text;
        ent.NUMARA = txtNumara.Text;
        ent.FOTOGRAF = txtFotograf.Text;
        ent.SIFRE = txtSifre.Text;
        ent.ID = Convert.ToInt32(txtId.Text);
        BLLOgrenci.BLLOgrenciGuncelle(ent);
        Response.Redirect("OgrenciListele.aspx");
    }
}

