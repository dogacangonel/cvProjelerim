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
using WindowsFormKOS.Model;
using WindowsFormsPersonelTakip.Model;

namespace WindowsFormKOS
{
    public partial class FormEmanet : Form
    {
        public FormEmanet()
        {
            InitializeComponent();
        }

        int okuyucuId = 0;
        int kitapId = 0;
        string gecikmeBedel = "";


        private void FormEmanet_Load(object sender, EventArgs e)
        {
            okuyucuLoad();
            kitaplarload();
        }

        void okuyucuLoad()
        {
            dgOkuyucu.DataSource = IDataBase.DataToDataTable("select * from okuyucular where aktif=1 and adi+' '+ soyadi like @search  ",new SqlParameter("@search", SqlDbType.VarChar) { Value=string.Format("%{0}%",txtFiltreleOkuyucu.Text) });
            dgOkuyucu.Columns["id"].Visible = false;
        }

        void kitaplarload()
        {
            dgKitaplar.DataSource = IDataBase.DataToDataTable("select * from kitaplar where durum=1 and aktif=1 and yazarAdi+' '+ kitapAdi like @search  ", new SqlParameter("@search", SqlDbType.VarChar) { Value = string.Format("%{0}%", txtFiltreleOkuyucu.Text) });
            dgKitaplar.Columns["id"].Visible = false;
        }

        void getOkuyucuProfil() 
        {
            pictureProfil.ImageLocation = Helper.profilpath(0);
            lblAdSoyad.Text = "";
            lblSinif.Text = "";
            lblOkulNo.Text = "";
            lblGecikmeBedeli.Text = "";

            foreach (DataRow row in IDataBase.DataToDataTable("select * from okuyucular where aktif=1 and id=@id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                pictureProfil.ImageLocation = Helper.profilpath(okuyucuId);
                lblAdSoyad.Text = row["adi"].ToString() + " " + row["soyadi"].ToString();
                lblSinif.Text = row["sinifi"].ToString();
                lblOkulNo.Text = row["OkulNo"].ToString();
                lblGecikmeBedeli.Text = "YOK";
            }

            int cezaTl = gecikmeBedeli();

            if (cezaTl==0)
            {
                gecikmeBedel = null;
            }
            else
            {
                gecikmeBedel = string.Format("{0:c}", cezaTl);
            }



            if (cezaTl>0)
            {
                lblGecikmeBedeli.Text = gecikmeBedel;
                lblGecikmeBedeli.BackColor = Color.Red;
            }
            else
            {
                lblGecikmeBedeli.Text = "Uygun";
                lblGecikmeBedeli.BackColor = Color.Transparent;
            }

            kitapId = getEmanetId();
            getKitapProfil();



        }

        void getKitapProfil()
        {
            lblKayitNo.Text = "";
            lblKitabinAdi.Text = "";
            lblYazarinAdi.Text = "";
            foreach (DataRow row in IDataBase.DataToDataTable("select * from kitaplar where aktif=1  and id=@id",new SqlParameter("@id", SqlDbType.Int) { Value=kitapId}).Rows)
            {
                lblKayitNo.Text = row["kayitNo"].ToString();
                lblKitabinAdi.Text = row["kitapAdi"].ToString();
                lblYazarinAdi.Text = row["yazarAdi"].ToString();
            }
        }

        void emanetEt()
        {
            if (getEmanetId()>0)
            {
                MessageBox.Show("Seçili kayıta emanet kitap vardır");
                return;
            }

            if (kitapId==0 || okuyucuId==0)
            {
                MessageBox.Show("Lütfen bir okuyucu veya kitap kaydı seçiniz ");
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapId", SqlDbType.Int) {Value=kitapId });
            parameters.Add(new SqlParameter("@okuyucuId", SqlDbType.Int) {Value=okuyucuId });
            parameters.Add(new SqlParameter("@emanetVerilisTarihi", SqlDbType.DateTime) {Value=DateTime.Now });
            parameters.Add(new SqlParameter("@emanetGeriAlmaTarihi", SqlDbType.DateTime) {Value=DateTime.Now.AddDays(30) });

            IDataBase.executeNonQuery("update kitaplar set durum=0 where id=@kitapId "+ 
                "insert into emanetler (kitapId,okuyucuId,emanetVerilisTarihi,emanetGeriAlmaTarihi) values (@kitapId,@okuyucuId,@emanetVerilisTarihi,@emanetGeriAlmaTarihi)",parameters );
            kitaplarload();
        }

        int getEmanetId()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select * from emanetler where durum=0 and aktif=1 and okuyucuId=@okuyucuId ", new SqlParameter("@okuyucuId", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                return Convert.ToInt32(row["kitapId"]);
            }
           
            return 0;
        }

        int gecikmeBedeli()
        {
            int cezaTl = 1;
            int gunFark = 0;
            foreach (DataRow row in IDataBase.DataToDataTable("select * from emanetler where durum=0 and aktif=1 and okuyucuId=@okuyucuId ", new SqlParameter("@okuyucuId", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                TimeSpan timeSpan = DateTime.Now - Convert.ToDateTime(row["emanetGeriAlmaTarihi"]);
                gunFark = timeSpan.Days;
            }

            if (gunFark>0)
            {
                return cezaTl = gunFark * cezaTl;
            }

            return 0;
        }

        void sureUzat()
        {
            if (getEmanetId() == 0)
            {
                MessageBox.Show("Seçili kayıta emanet kitap yoktur.");
                return;
            }

            if (kitapId == 0 || okuyucuId == 0)
            {
                MessageBox.Show("Lütfen bir okuyucu veya kitap kaydı seçiniz ");
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapId", SqlDbType.Int) { Value = kitapId });
            parameters.Add(new SqlParameter("@emanetVerilisTarihi", SqlDbType.DateTime) { Value = DateTime.Now });
            parameters.Add(new SqlParameter("@emanetGeriAlmaTarihi", SqlDbType.DateTime) { Value = DateTime.Now.AddDays(30) });

            IDataBase.executeNonQuery("update emanetler set emanetVerilisTarihi=@emanetVerilisTarihi ,emanetGeriAlmaTarihi=@emanetGeriAlmaTarihi where kitapId=@kitapId ", parameters);

            kitaplarload();
            getOkuyucuProfil();
        }

        void dusumYap()
        {
            if (getEmanetId() == 0)
            {
                MessageBox.Show("Seçili kayıta emanet kitap yoktur.");
                return;
            }

            if (kitapId == 0 || okuyucuId == 0)
            {
                MessageBox.Show("Lütfen bir okuyucu veya kitap kaydı seçiniz ");
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapId", SqlDbType.Int) { Value = kitapId });
            parameters.Add(new SqlParameter("@emanetIslemTarihi", SqlDbType.DateTime) { Value = DateTime.Now });
            

            IDataBase.executeNonQuery("update kitaplar set durum=1 where id=@kitapId " +
                "update emanetler set durum=1 , emanetIslemTarihi=@emanetIslemTarihi where kitapId=@kitapId ", parameters);

            kitaplarload();
            getOkuyucuProfil();
        }

        private void txtFiltreleOkuyucu_TextChanged(object sender, EventArgs e)
        {
            okuyucuLoad();
        }

        private void txtFiltreleKitap_TextChanged(object sender, EventArgs e)
        {
            kitaplarload();
        }

        private void dgOkuyucu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                okuyucuId =Convert.ToInt32( dgOkuyucu.Rows[e.RowIndex].Cells["id"].Value);
                getOkuyucuProfil();
            }
        }

        private void dgKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex>-1)
            {
                if (okuyucuId == 0)
                {
                    MessageBox.Show("Lütfen okuyucu seçiniz");
                    return;
                }

                if (getEmanetId() > 0)
                {
                    MessageBox.Show("Seçili kaydın emaneti vardır");
                    return;
                }


                kitapId = Convert.ToInt32( dgKitaplar.Rows[e.RowIndex].Cells["id"].Value);
                getKitapProfil();
            }
        }

        private void btnEmanetEt_Click(object sender, EventArgs e)
        {
            emanetEt();
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gecikmeBedel))
            {
               
                DialogResult dialogResult = MessageBox.Show("Seçili kaydın "+gecikmeBedel+" vardır","Gecikme Bedeli",MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    sureUzat();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kaydın gecikme bedeli yoktur.Süreyi uzatmak ister misiniz?", "Süre Uzatma", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sureUzat();
                    MessageBox.Show("Süre uzatıldı.");
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
        }

        private void btnDusumYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gecikmeBedel))
            {

                DialogResult dialogResult = MessageBox.Show("Seçili kaydın " + gecikmeBedel + " vardır", "Düşüm yap", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dusumYap();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kaydın gecikme bedeli yoktur.Düşüm yapmak ister misiniz?", "Düşüm Yap", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dusumYap();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
        }
    }
}
