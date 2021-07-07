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
    public partial class FormKitapEkle : Form
    {
        public FormKitapEkle()
        {
            InitializeComponent();
        }

        int kitapId = 0;
        private void FormKitapEkle_Load(object sender, EventArgs e)
        {
            comboBoxFill();
            KitapLoad();
        }

        void comboBoxFill()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("Select * from dolaplar").Rows)
                comboDolap.Items.Add(row["adi"].ToString());

            foreach (DataRow row in IDataBase.DataToDataTable("Select * from turler").Rows)
                comboTuru.Items.Add(row["adi"].ToString());

            foreach (DataRow row in IDataBase.DataToDataTable("Select * from yayinevleri").Rows)
                comboYayinEvi.Items.Add(row["adi"].ToString());

            foreach (DataRow row in IDataBase.DataToDataTable("Select * from yazarlar").Rows)
                comboYazarAdi.Items.Add(row["adi"].ToString());

        }

        void KitapLoad()
        {
            dg.DataSource = IDataBase.DataToDataTable("select * from kitaplar where aktif=1 and yazarAdi+''+kitapAdi like @search",new SqlParameter("@search", SqlDbType.VarChar) {Value=string.Format("%{0}%",txtFiltrele.Text) });
            dg.Columns["id"].Visible=false;

        }

        int getKayitNo()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select ISNULL(Max(kayitNo),0)+1 from kitaplar where aktif=1").Rows) 
            {
                 return Convert.ToInt32(row[0]);
            }
            return 1;

        }

        void KitapEkle()
        {
            int kayitNo = getKayitNo();

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kayitNo", SqlDbType.Int) { Value = kayitNo });
            parameters.Add(new SqlParameter("@kitapAdi", SqlDbType.VarChar) { Value = txtKitabinAdi.Text });
            parameters.Add(new SqlParameter("@yazarAdi", SqlDbType.VarChar) { Value = comboYazarAdi.Text });
            parameters.Add(new SqlParameter("@yayinevi", SqlDbType.VarChar) { Value = comboYayinEvi.Text });
            parameters.Add(new SqlParameter("@basimYili", SqlDbType.VarChar) { Value = txtBasimYili.Text });
            parameters.Add(new SqlParameter("@sayfaSayisi", SqlDbType.VarChar) { Value = txtSayfaSayisi.Text });
            parameters.Add(new SqlParameter("@tur", SqlDbType.VarChar) { Value = comboTuru.Text });
            parameters.Add(new SqlParameter("@aciklama", SqlDbType.VarChar) { Value = txtAciklama.Text });
            parameters.Add(new SqlParameter("@dolap", SqlDbType.VarChar) { Value = comboDolap.Text });
            parameters.Add(new SqlParameter("@raf", SqlDbType.VarChar) { Value = txtRaf.Text });
            parameters.Add(new SqlParameter("@sira", SqlDbType.VarChar) { Value = txtSira.Text });

            IDataBase.executeNonQuery("insert into kitaplar (kayitNo,kitapAdi,yazarAdi,yayinevi,basimYili,sayfaSayisi,tur,aciklama,dolap,raf,sira) values (@kayitNo,@kitapAdi,@yazarAdi,@yayinevi,@basimYili,@sayfaSayisi,@tur,@aciklama,@dolap,@raf,@sira)", parameters);

            txtKayıtNo.Text = kayitNo.ToString();
            KitapTemizle();
            KitapLoad();
            MessageBox.Show("Kayıt işlemi başarıyla kaydedildi.");
            
        }

        void KitapGuncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapAdi", SqlDbType.VarChar) { Value = txtKitabinAdi.Text });
            parameters.Add(new SqlParameter("@yazarAdi", SqlDbType.VarChar) { Value = comboYazarAdi.Text });
            parameters.Add(new SqlParameter("@yayinevi", SqlDbType.VarChar) { Value = comboYayinEvi.Text });
            parameters.Add(new SqlParameter("@basimYili", SqlDbType.VarChar) { Value = txtBasimYili.Text });
            parameters.Add(new SqlParameter("@sayfaSayisi", SqlDbType.VarChar) { Value = txtSayfaSayisi.Text });
            parameters.Add(new SqlParameter("@tur", SqlDbType.VarChar) { Value = comboTuru.Text });
            parameters.Add(new SqlParameter("@aciklama", SqlDbType.VarChar) { Value = txtAciklama.Text });
            parameters.Add(new SqlParameter("@dolap", SqlDbType.VarChar) { Value = comboDolap.Text });
            parameters.Add(new SqlParameter("@raf", SqlDbType.VarChar) { Value = txtRaf.Text });
            parameters.Add(new SqlParameter("@sira", SqlDbType.VarChar) { Value = txtSira.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = kitapId});


            IDataBase.executeNonQuery("update kitaplar set kitapAdi=@kitapAdi,yazarAdi=@yazarAdi,yayinevi=@yayinevi,basimYili=@basimYili,sayfaSayisi=@sayfaSayisi,tur=@tur,aciklama=@aciklama,dolap=@dolap,raf=@raf,sira=@sira where id=@id", parameters);
           
            KitapLoad();
            KitapTemizle();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }

        void KitapSil()
        {
            
            IDataBase.executeNonQuery("update kitaplar set aktif=0 where id=@id", new SqlParameter("@id", SqlDbType.Int) {Value=kitapId });
            KitapLoad();
            KitapTemizle();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.");

        }

        void KitapTemizle ()
        {
            kitapId = 0;
            foreach (var item in tableLayoutPanel.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";

                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).Text = "";
                }


            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKitabinAdi.Text) || string.IsNullOrEmpty(comboYazarAdi.Text) || string.IsNullOrEmpty(comboTuru.Text))
            {
                MessageBox.Show("Kitap Adı, Yazar Adı ve Türü boş geçilemez.");
                return;
            }

            if (kitapId>0)
            {
                KitapGuncelle();
                
            }
            else
            {
                KitapEkle();
                
            }
                   
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);
            if (e.RowIndex>-1)
            {
                foreach (DataRow row in IDataBase.DataToDataTable("select * from kitaplar where aktif=1 and id=@id", new SqlParameter("@id", SqlDbType.Int) { Value = kitapId }).Rows) 
                {
                    txtKayıtNo.Text = row["kayitNo"].ToString();
                    txtKitabinAdi.Text= row["kitapAdi"].ToString();
                    comboYazarAdi.Text= row["yazarAdi"].ToString();
                    comboYayinEvi.Text= row["yayinevi"].ToString();
                    txtBasimYili.Text= row["basimYili"].ToString();
                    txtSayfaSayisi.Text= row["sayfaSayisi"].ToString();
                    comboTuru.Text = row["tur"].ToString();
                    txtAciklama.Text = row["aciklama"].ToString();
                    comboDolap.Text = row["dolap"].ToString();
                    txtRaf.Text = row["raf"].ToString();
                    txtSira.Text= row["sira"].ToString();
                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kitapId > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kayıdı silmek istediğinizden emin misiniz?", "Kitap Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    KitapSil();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
        }

        private void txtFiltrele_TextChanged(object sender, EventArgs e)
        {
            KitapLoad();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KitapTemizle();
        }
    }
}
