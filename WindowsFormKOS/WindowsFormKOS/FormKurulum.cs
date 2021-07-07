using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPersonelTakip.Model;

namespace WindowsFormKOS
{
    public partial class FormKurulum : Form
    {
        public FormKurulum()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text)|| string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtSifreTekrar.Text) )
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz...");
                return;
            }

            if (txtSifre.Text!=txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler Birbirleriyle uyuşmamaktadır...");
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            parameters.Add(new SqlParameter("@kullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });
            parameters.Add(new SqlParameter("@sifre", SqlDbType.VarChar) { Value = txtSifre.Text });
            IDataBase.executeNonQuery("insert into kullanicilar (adi,soyadi,kullaniciAdi,sifre) values(@adi,@soyadi,@kullaniciAdi,@sifre)", parameters);

            FormLogin formlogin = new FormLogin();
            formlogin.Show();
            this.Hide();
        }
    }
}
