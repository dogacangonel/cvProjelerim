using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OgrenciTakipProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+Application.StartupPath +"/denemeOgrenci.accdb";
        int ogrenciId = 0;


        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (ogrenciId == 0)
                {
                    
                    Ekle();
                }
                else
                {
                    
                    MessageBox.Show("Seçili öğrenci vardır.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Boş kayıt öğrenci bilgisi oluşturulamaz");
                
            }
           
       
            /* addWithValue();*/
          
        }


        void addWithValue()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                cmd = new OleDbCommand("insert into denemeOgrenci (Ad, Soyad, Cinsiyet, Sinifi, Numarasi) values (@adi,@soyadi,@cinsiyeti,@sinifi,@numarasi) ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@adi",txtAdi.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
                string cinsiyet = "";
                if (radioErkek.Checked)
                {
                    cinsiyet = "Erkek";

                }
                else if (radioKadin.Checked)
                {
                    cinsiyet = "Kadın";
                }
                cmd.Parameters.AddWithValue("@cinsiyeti", cinsiyet);
                cmd.Parameters.AddWithValue("sinifi", comboBox.Text);
                cmd.Parameters.AddWithValue("numarasi", txtNumara.Text);
                cmd.ExecuteNonQuery();

            }
            catch (OleDbException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
           

        }

        void Ekle()
        {
            


            try
            {
                con = new OleDbConnection(connectionString);
                cmd = new OleDbCommand("insert into denemeOgrenci (Ad, Soyad, Cinsiyet, Sinifi, Numarasi) values (@adi,@soyadi,@cinsiyeti,@sinifi,@numarasi) ", con);
                con.Open();
                cmd.Parameters.Add("@adi", OleDbType.VarChar).Value = txtAdi.Text;
                cmd.Parameters.Add("@soyadi", OleDbType.VarChar).Value = txtSoyadi.Text;
                string cinsiyet = "";
                if (radioErkek.Checked)
                {
                    cinsiyet = radioErkek.Text;

                }
                else if (radioKadin.Checked)
                {
                    cinsiyet = radioKadin.Text;
                }
                cmd.Parameters.Add("@cinsiyeti",OleDbType.VarChar).Value=cinsiyet;
                cmd.Parameters.Add("@sinifi",OleDbType.VarChar).Value=comboBox.Text;
                cmd.Parameters.Add("@numarasi",OleDbType.Integer).Value=txtNumara.Text;
                cmd.ExecuteNonQuery();

                

            }
            catch (OleDbException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            OgrenciYukle();

        }

        void Guncelle()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                cmd = new OleDbCommand("update denemeOgrenci set  Ad=@adi, Soyad=@soyadi, Cinsiyet=@cinsiyeti, Sinifi=@sinifi,Numarasi=@numarasi where id=@id ", con);
                con.Open();
                cmd.Parameters.Add("@adi", OleDbType.VarChar).Value = txtAdi.Text;
                cmd.Parameters.Add("@soyadi", OleDbType.VarChar).Value = txtSoyadi.Text;
                string cinsiyet = "";
                if (radioErkek.Checked)
                {
                    cinsiyet = radioErkek.Text;

                }
                else if (radioKadin.Checked)
                {
                    cinsiyet = radioKadin.Text;
                }
                cmd.Parameters.Add("@cinsiyeti", OleDbType.VarChar).Value = cinsiyet;
                cmd.Parameters.Add("@sinifi", OleDbType.VarChar).Value = comboBox.Text;
                cmd.Parameters.Add("@numarasi", OleDbType.Integer).Value = txtNumara.Text;
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = ogrenciId;
                cmd.ExecuteNonQuery();

                

            }
            catch (OleDbException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

            OgrenciYukle();

            Temizle();
        }

        void Sil()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                cmd = new OleDbCommand("delete from denemeOgrenci where id=@id ", con);
                con.Open();                              
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = ogrenciId;
                cmd.ExecuteNonQuery();



            }
            catch (OleDbException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

            OgrenciYukle();
            
        }

        void OgrenciYukle ()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                cmd = new OleDbCommand("Select * from denemeOgrenci",con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGrid.DataSource = dt;
                /*dataGrid.Columns["id"].Visible = false;*/
                

            }
            catch (OleDbException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        void Temizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            radioErkek.Checked = false;
            radioKadin.Checked = false;
            comboBox.Text = "";
            txtNumara.Text = "";

          /*  foreach ( var item in tableLayoutOgrenci.Controls) // Çok uzun texbox veya combobox olması durumunda tek tek yazmak yerine kullanılabilinir
            {
                if (item is TextBox)
                    ((TextBox)item).Text.c

                if (item is ComboBox)
                    ((ComboBox)item).Text = "";

                

            }

            foreach (var item in tableLayoutPanel2.Controls)
            {
                if (item is RadioButton)
                    ((RadioButton)item).Checked = false;
            }*/
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          /*  MessageBox.Show(Application.StartupPath);*/
            OgrenciYukle();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());*/
            if (e.RowIndex>-1)
            {
                try
                {
                    ogrenciId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["id"].Value);

                    con = new OleDbConnection(connectionString);
                    cmd = new OleDbCommand("select * from denemeOgrenci Where id=@id", con);
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = ogrenciId;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    radioErkek.Checked = false;
                    radioKadin.Checked = false;


                    foreach (DataRow row in dt.Rows)
                    {
                        txtAdi.Text = row["Ad"].ToString();
                        txtSoyadi.Text = row["Soyad"].ToString();
                        string cinsiyet = row["Cinsiyet"].ToString();
                        if (cinsiyet=="Erkek")
                        {
                            radioErkek.Checked = true;
                        }
                        else if (cinsiyet=="Kadın")
                        {
                            radioKadin.Checked = true;
                        }
                        comboBox.Text = row["Sinifi"].ToString();
                        txtNumara.Text = row["Numarasi"].ToString();
                    }
                }
                catch (OleDbException ex)
                {

                    throw ex;
                }
            }
            

        }

      

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (ogrenciId > 0)
                {
                    Guncelle();
                }
                else
                {
                    MessageBox.Show("Öğrenci Seçiniz");
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Boş bilgi güncellenemez!");
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ogrenciId>0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?", "Öğrenci Sil", MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    Sil();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.")  ;
                    
                }
            }
            else
            {
                MessageBox.Show("Öğrenci Seçiniz");
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
