using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPersonelTakip.Model;

namespace WindowsFormKOS
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }

        string query = "";
        void istatistikYukle()
        {
            switch (comboIstatistik.SelectedIndex)
            {
                case 0:
                    query = "select adi+' '+soyadi as X ,COUNT(*) as Y  from emanetler inner join okuyucular on emanetler.okuyucuId=okuyucular.id where emanetler.aktif=okuyucular.aktif group by adi+' '+soyadi";
                    break;
                case 1:
                    query = "select kitapAdi as X, COUNT(*) as Y  from emanetler inner join kitaplar on emanetler.kitapId =kitaplar.id where emanetler.aktif=kitaplar.aktif group by kitapAdi";
                    break;
                case 2:
                    query = "select yazarAdi as X , COUNT(*) as Y  from emanetler inner join kitaplar on emanetler.kitapId =kitaplar.id where emanetler.aktif=kitaplar.aktif group by yazarAdi";
                    break;
                case 3:
                    query = "select tur as X, COUNT(*) as Y from emanetler inner join kitaplar on emanetler.kitapId =kitaplar.id where emanetler.aktif=kitaplar.aktif group by tur";
                    break;
                default:
                    break;

            }


            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }

            foreach (DataRow row in IDataBase.DataToDataTable(query).Rows)
            {
                chart.Series["Durum"].Points.AddXY(row["X"].ToString(), row["Y"].ToString());

            }
        }

  
        private void comboIstatistik_SelectedIndexChanged(object sender, EventArgs e)
        {
            istatistikYukle();
        }
    }
}
