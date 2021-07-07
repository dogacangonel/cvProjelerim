using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormKOS.Model;
using WindowsFormsPersonelTakip.Model;

namespace WindowsFormKOS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        void dataGridViewYukle()
        {
            dgEmanetKitap.DataSource = IDataBase.DataToDataTable("select * from kitaplar where durum=0 and aktif=1");
            dgMevcutKitaplar.DataSource= IDataBase.DataToDataTable("select * from kitaplar where durum=1 and aktif=1");
            dgOkuyucu.DataSource= IDataBase.DataToDataTable("select * from okuyucular where aktif=1");
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FormKitapEkle formKitapEkle = new FormKitapEkle();
            formKitapEkle.Show();
        }

        private void btnOkuyucuEkle_Click(object sender, EventArgs e)
        {
            FormOkuyucuEkle formOkuyucuEkle = new FormOkuyucuEkle();
            formOkuyucuEkle.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
            
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();
            formEdit.Show();
        }

        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            FormEmanet formEmanet = new FormEmanet();
            formEmanet.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FormIstatistik formIstatistik = new FormIstatistik();
            formIstatistik.Show();
        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
            dataGridViewYukle();
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
