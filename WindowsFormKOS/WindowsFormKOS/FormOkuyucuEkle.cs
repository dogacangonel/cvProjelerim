using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormKOS.Model;
using WindowsFormsPersonelTakip.Model;

namespace WindowsFormKOS
{
    public partial class FormOkuyucuEkle : Form
    {
        public FormOkuyucuEkle()
        {
            InitializeComponent();
        }
        int okuyucuId = 0;
        string okuyucuFoto = "";

        private void FormOkuyucuEkle_Load(object sender, EventArgs e)
        {
            okuyucularLoad();
        }

        void OkuyucularGüncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAdi.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyadi.Text });
            string cinsiyeti = "";
            if (radioButtonErkek.Checked)
            {
                cinsiyeti = radioButtonErkek.Text;
            }
            else if (radioButtonKadin.Checked)
            {
                cinsiyeti = radioButtonKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyeti", SqlDbType.VarChar) { Value = cinsiyeti });
            parameters.Add(new SqlParameter("@sinifi", SqlDbType.VarChar) { Value = txtSinifi.Text });
            parameters.Add(new SqlParameter("@okulNo", SqlDbType.VarChar) { Value = txtOkulNo.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.VarChar) { Value = okuyucuId });

            IDataBase.executeNonQuery("update okuyucular set adi=@adi, soyadi=@soyadi, cinsiyeti=@cinsiyeti, sinifi=@sinifi, okulNo=okulNo, cepTel=@cepTel, adres=@adres where id=@id", parameters);
          
            fotoSave();
            okuyucularLoad();
            okuyucuTemizleme();
            MessageBox.Show("Kayıt başarıyla güncellendi");
        }

        void OkuyucularEkle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAdi.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyadi.Text });
            string cinsiyeti = "";
            if (radioButtonErkek.Checked)
            {
                cinsiyeti = radioButtonErkek.Text;
            }
            else if (radioButtonKadin.Checked)
            {
                cinsiyeti = radioButtonKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyeti", SqlDbType.VarChar) { Value = cinsiyeti });
            parameters.Add(new SqlParameter("@sinifi", SqlDbType.VarChar) { Value = txtSinifi.Text });
            parameters.Add(new SqlParameter("@okulNo", SqlDbType.VarChar) { Value = txtOkulNo.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });

            object value = IDataBase.ExecuteScalar("insert into okuyucular (adi, soyadi, cinsiyeti, sinifi, okulNo, cepTel, adres) values (@adi, @soyadi, @cinsiyeti, @sinifi, @okulNo, @cepTel, @adres) select @@identity", parameters);
            okuyucuId = Convert.ToInt32(value);
            fotoSave();
            okuyucularLoad();
            okuyucuTemizleme();
            MessageBox.Show("Kayıt başarıyla kayıt edildi.");
        }  

        void okuyucularLoad()
        {
            dg.DataSource = IDataBase.DataToDataTable("select * from okuyucular where aktif=1 and adi+' '+soyadi like @search", new SqlParameter("@search", SqlDbType.VarChar) { Value = string.Format("%{0}%", txtFiltre.Text) });
            dg.Columns["id"].Visible = false;
           
        }

        void fotoSave()
        {
            if (!string.IsNullOrEmpty(okuyucuFoto))
            {
                File.Copy(okuyucuFoto, Application.StartupPath + "/profil/" + okuyucuId + ".jpg", true);
            }
        }

        void okuyucuSil()
        {
            IDataBase.DataToDataTable("update okuyucular set aktif=0  where id=@id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });
            okuyucuTemizleme();
            okuyucularLoad();
            MessageBox.Show("Kayıt başarıyla silindi");
        }

        void okuyucuTemizleme ()
        {
            okuyucuId = 0;
            okuyucuFoto = "";
            pictureBoxFoto.ImageLocation = Helper.profilpath(0);

            radioButtonErkek.Checked = false;
            radioButtonKadin.Checked = false;

            foreach (var item in tableLayoutPanel.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                    
                }

                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }

            }
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text) || maskedCepTel.MaskFull==false)
            {
                MessageBox.Show("Ad, Soyad ve Cep Telefonu numarası boş geçilemez");
                return;
            }

            if (okuyucuId>0)
            {
                OkuyucularGüncelle();
            }
            else
            {
                OkuyucularEkle();
            }
           
           
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                okuyucuFoto = openFileDialog.FileName;
                pictureBoxFoto.ImageLocation = okuyucuFoto;
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex>-1)
            {

                okuyucuId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);

                pictureBoxFoto.ImageLocation = Helper.profilpath(okuyucuId);

                radioButtonErkek.Checked = false;
                radioButtonKadin.Checked = false;
                foreach (DataRow row in IDataBase.DataToDataTable("select * from okuyucular where aktif=1 and id=@id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
                {
                    txtAdi.Text = row["adi"].ToString();
                    txtSoyadi.Text = row["soyadi"].ToString();
                    string cinsiyeti = row["cinsiyeti"].ToString();
                    if (cinsiyeti == radioButtonErkek.Text)
                    {
                        radioButtonErkek.Checked = true;
                    }
                    else if (cinsiyeti == radioButtonKadin.Text)
                    {
                        radioButtonKadin.Checked = true;
                    }
                    txtSinifi.Text = row["sinifi"].ToString();
                    txtOkulNo.Text = row["okulNo"].ToString();
                    maskedCepTel.Text = row["cepTel"].ToString();
                    txtAdres.Text = row["adres"].ToString();

                }
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (okuyucuId>0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçilen kaydı silmek istediğinize emin misiniz", "Okuyucu Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    okuyucuSil();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz");
            }
           
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            okuyucuTemizleme();
        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            okuyucularLoad();
        }
    }
}
