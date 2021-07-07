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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        int rowId = 0;

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }


        string getTableName ()
        {
            switch (comboBoxTabloSec.SelectedIndex)
            {
                case 0:
                    return "yazarlar";
                case 1:
                    return "yayinevleri";
                case 2:
                    return "turler";
                case 3:
                    return "dolaplar";     

                default:
                    return"";
            }

            
        }
        
        void tableLoad()
        {
            dg.DataSource = IDataBase.DataToDataTable("select * from " + getTableName());
            dg.Columns["id"].Visible = false;
        }

        void tabloEkle ()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("adi", SqlDbType.VarChar) {Value=txtTabloAdi.Text });
            IDataBase.executeNonQuery("insert into "+getTableName()+" (adi) values (@adi) ",parameters);
            tableLoad();
            MessageBox.Show("İşlem başarıyla kayıt edildi");
            tabloTemizle();
        }

        void tabloGuncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtTabloAdi.Text });
            parameters.Add(new SqlParameter("id", SqlDbType.Int) { Value = rowId });
            IDataBase.executeNonQuery("update " + getTableName() + " set adi=@adi where id=@id",parameters );
            tabloTemizle();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
            tableLoad();
        }

        void tabloSil()
        {
           
            IDataBase.DataToDataTable("delete " + getTableName() + " where id=@id", new SqlParameter("@id", SqlDbType.VarChar) { Value = rowId });
            tableLoad();
            MessageBox.Show("Tablo başarıyla silindi" );
            tabloTemizle();
        }

        void tabloTemizle()
        {
            rowId = 0;
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }

            
            }
        }


        private void comboBoxTabloSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getTableName())) 
            {
                MessageBox.Show("Lütfen bir kitap seçiniz");
                return;
            }

            if (rowId>0)
            {
                tabloGuncelle();
            }
            else
            {
                tabloEkle();
            }
            
        }


        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                rowId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);
                txtTabloAdi.Text = dg.Rows[e.RowIndex].Cells["adi"].Value.ToString();
                

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rowId>0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kaydı silmek isyediğinize emin misiniz?","Tablo sil",MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    tabloSil();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tabloTemizle();
        }
    }
}
