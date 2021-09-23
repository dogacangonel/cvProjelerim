using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class AnaSayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ogrenci = new EntityOgrenci();
        ogrenci.AD = txtAd.Text;
        ogrenci.SOYAD = txtSoyad.Text;
        ogrenci.NUMARA = txtNumara.Text;
        ogrenci.FOTOGRAF = txtFotograf.Text;
        ogrenci.SIFRE = txtSifre.Text;
        BLLOgrenci.OgrenciEkleBLL(ogrenci);
    }
}