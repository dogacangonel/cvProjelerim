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

namespace WindowsFormsPersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* SqlConnection con;
        SqlCommand cmd;
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonelDB;Integrated Security=SSPI";*/
        int personelID = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            birimLoad();
            personelLoad();
        }


        void birimLoad()
        {

            /*try
             {

                 con = new SqlConnection(connectionString);
                 cmd = new SqlCommand("select * from birim", con);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);

                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 foreach (DataRow row in dt.Rows)
                 {
                     comboBoxBirim.Items.Add(row["birim"].ToString());
                 }
             }
             catch (SqlException ex)
             {

                 throw ex;
             }*/

            foreach (DataRow row in IDataBase.DataToDataTable("select * from birim").Rows)
            {
                comboBoxBirim.Items.Add(row["birim"].ToString());
            }


        }

     

        void personelEkle()
        {
            /* try
             {
                 con = new SqlConnection(connectionString);
                 cmd = new SqlCommand("insert into personeller (SicilNo,isim,soyad,cinsiyet,dogumTarihi,birim,cepTel,adres) values (@SicilNo,@isim,@soyad,@cinsiyet,@dogumTarihi,@birim,@cepTel,@adres) ", con);
                 con.Open();

                 cmd.Parameters.Add("@SicilNo", SqlDbType.Int).Value = txtSicilNo.Text;
                 cmd.Parameters.Add("@isim", SqlDbType.VarChar).Value = txtAdi.Text;
                 cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = txtSoyadi.Text;
                 string cinsiyet = "";
                 if (radioErkek.Checked)
                 {
                     cinsiyet = radioErkek.Text;
                 }
                 else if (radioKadin.Checked)
                 {
                     cinsiyet = radioKadin.Text;
                 }
                 cmd.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = cinsiyet;
                 cmd.Parameters.Add("@dogumTarihi", SqlDbType.Date).Value = maskedDogumTarihi.Text;
                 cmd.Parameters.Add("@birim", SqlDbType.VarChar).Value = comboBoxBirim.Text;
                 cmd.Parameters.Add("@cepTel", SqlDbType.VarChar).Value = maskedTelefon.Text;
                 cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
                 cmd.ExecuteNonQuery();

             }
             catch (SqlException ex)
             {

                 throw ex;
             }
             finally
             {

                 con.Close();
             }*/

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@SicilNo", SqlDbType.Int) { Value = txtSicilNo.Text });
            parameters.Add(new SqlParameter("@isim", SqlDbType.VarChar) { Value = txtAdi.Text });
            parameters.Add(new SqlParameter("@soyad", SqlDbType.VarChar) { Value = txtSoyadi.Text });
            string cinsiyet = "";
            if (radioErkek.Checked)
            {
                cinsiyet = radioErkek.Text;

            }
            else if (radioKadin.Checked)
            {
                cinsiyet = radioKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyet", SqlDbType.VarChar) { Value = cinsiyet });
            parameters.Add(new SqlParameter("@dogumTarihi", SqlDbType.Date) { Value = maskedDogumTarihi.Text });
            parameters.Add(new SqlParameter("@birim", SqlDbType.VarChar) { Value = comboBoxBirim.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedTelefon.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });

            IDataBase.executeNonQuery("insert into personeller (SicilNo,isim,soyad,cinsiyet,dogumTarihi,birim,cepTel,adres) values (@SicilNo,@isim,@soyad,@cinsiyet,@dogumTarihi,@birim,@cepTel,@adres)",parameters);


            personelLoad();
            
        }


        void personelLoad()
        {
            /* try
             {
                 con = new SqlConnection(connectionString);
                 cmd = new SqlCommand("select * from personeller", con);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 dataGridView.DataSource = dt;
                 dataGridView.Columns["id"].Visible = false;
             }
             catch (SqlException ex)
             {

                 throw ex;
             }*/

            dataGridView.DataSource = IDataBase.DataToDataTable("select * from personeller");
            dataGridView.Columns["id"].Visible=false;

        }

        void personelGuncelle()
        {
            /* try
             {
                 con = new SqlConnection(connectionString);
                 cmd = new SqlCommand("update personeller set SicilNo=@SicilNo,isim=@isim,soyad=@soyad,cinsiyet=@cinsiyet,dogumTarihi=@dogumTarihi,@birim=@birim,cepTel=@cepTel,adres=@adres where id=@id", con);
                 con.Open();
                 cmd.Parameters.Add("@SicilNo", SqlDbType.Int).Value = txtSicilNo.Text;
                 cmd.Parameters.Add("@isim", SqlDbType.VarChar).Value = txtAdi.Text;
                 cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = txtSoyadi.Text;
                 string cinsiyet = "";
                 if (radioErkek.Checked)
                 {
                     cinsiyet = radioErkek.Text;
                 }
                 else if (radioKadin.Checked)
                 {
                     cinsiyet = radioKadin.Text;
                 }
                 cmd.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = cinsiyet;
                 cmd.Parameters.Add("@dogumTarihi", SqlDbType.Date).Value = maskedDogumTarihi.Text;
                 cmd.Parameters.Add("@birim", SqlDbType.VarChar).Value = comboBoxBirim.Text;
                 cmd.Parameters.Add("@cepTel", SqlDbType.VarChar).Value = maskedTelefon.Text;
                 cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
                 cmd.Parameters.Add("@id", SqlDbType.Int).Value = personelID;
                 cmd.ExecuteNonQuery();
                 personelLoad();
             }
             catch (SqlException ex)
             {

                 throw ex;
             }
             finally
             {
                 con.Close();
             }*/

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@SicilNo", SqlDbType.Int) { Value = txtSicilNo.Text });
            parameters.Add(new SqlParameter("@isim", SqlDbType.VarChar) { Value = txtAdi.Text });
            parameters.Add(new SqlParameter("@soyad", SqlDbType.VarChar) { Value = txtSoyadi.Text });
            string cinsiyet = "";
            if (radioErkek.Checked)
            {
                cinsiyet = radioErkek.Text;

            }
            else if (radioKadin.Checked)
            {
                cinsiyet = radioKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyet", SqlDbType.VarChar) { Value = cinsiyet });
            parameters.Add(new SqlParameter("@dogumTarihi", SqlDbType.Date) { Value = maskedDogumTarihi.Text });
            parameters.Add(new SqlParameter("@birim", SqlDbType.VarChar) { Value = comboBoxBirim.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedTelefon.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = personelID });


            IDataBase.executeNonQuery("update personeller set SicilNo=@SicilNo,isim=@isim,soyad=@soyad,cinsiyet=@cinsiyet,dogumTarihi=@dogumTarihi,@birim=@birim,cepTel=@cepTel,adres=@adres where id=@id", parameters);


            personelLoad();
        }

        void personelSil()
        {
            /* try
             {
                 con = new SqlConnection(connectionString);
                 cmd = new SqlCommand("delete personeller where id=@id", con);
                 con.Open();
                 cmd.Parameters.Add("@id", SqlDbType.Int).Value = personelID;
                 cmd.ExecuteNonQuery();
                 personelLoad();
             }
             catch (SqlException ex)
             {

                 throw ex;
             }
             finally
             {
                 con.Close();
             }*/

            IDataBase.executeNonQuery("delete personeller where id=@id", new SqlParameter("@id", SqlDbType.VarChar) { Value = personelID});

            personelLoad();
        }

        void personelTemizle()
        {
            if (personelID > 0)
            {
                foreach (var item in tableLayoutPanel1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = "";
                    }

                    if (item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Text = "";
                    }

                    if (item is CheckBox)
                    {
                        ((CheckBox)item).Text = "";
                    }
                }

                foreach (var item in tableLayoutPanel2.Controls)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (personelID == 0)
                {
                    personelEkle();
                    personelTemizle();
                }
                else if(personelID>0)
                {
                    MessageBox.Show("Yanlış deneme...");
                }

            }
            catch (FormatException)
            {

                MessageBox.Show("Boş veya yanlış veri giriyorsunuz.Kontrol ediniz.");
            }



        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                personelID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].Value);
                /*try
                {
                    

                    con = new SqlConnection(connectionString);
                    cmd = new SqlCommand("select * from personeller where id=@id", con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = personelID;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    radioErkek.Checked = false;
                    radioKadin.Checked = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        txtSicilNo.Text = row["SicilNo"].ToString();
                        txtAdi.Text = row["isim"].ToString();
                        txtSoyadi.Text = row["soyad"].ToString();
                        string cinsiyet = row["cinsiyet"].ToString();


                        if (cinsiyet == radioErkek.Text)
                        {
                            radioErkek.Checked = true;
                        }
                        else if (cinsiyet == radioKadin.Text)
                        {
                            radioKadin.Checked = true;
                        }
                        maskedDogumTarihi.Text = string.Format("{0:dd/MM/yyyy}", row["dogumTarihi"]);
                        comboBoxBirim.Text = row["birim"].ToString();
                        maskedTelefon.Text = row["Ceptel"].ToString();
                        txtAdres.Text = row["adres"].ToString();
                    }
                }
                catch (SqlException ex)
                {

                    throw ex;
                }*/

                radioErkek.Checked = false;
                radioKadin.Checked = false;

                foreach (DataRow row in IDataBase.DataToDataTable("select * from personeller where id=@id", new SqlParameter("@id", SqlDbType.Int) {Value=personelID }).Rows)
                {
                    txtSicilNo.Text = row["SicilNo"].ToString();
                    txtAdi.Text = row["isim"].ToString();
                    txtSoyadi.Text = row["soyad"].ToString();
                    string cinsiyet = row["cinsiyet"].ToString();


                    if (cinsiyet == radioErkek.Text)
                    {
                        radioErkek.Checked = true;
                    }
                    else if (cinsiyet == radioKadin.Text)
                    {
                        radioKadin.Checked = true;
                    }
                    maskedDogumTarihi.Text = string.Format("{0:dd/MM/yyyy}", row["dogumTarihi"]);
                    comboBoxBirim.Text = row["birim"].ToString();
                    maskedTelefon.Text = row["Ceptel"].ToString();
                    txtAdres.Text = row["adres"].ToString();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (personelID > 0)
                {
                    personelGuncelle();
                }
                else
                {
                    MessageBox.Show("Lütfen bir personel seçiniz...");
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Yanlış Deneme");
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (personelID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili personeli silmek istediğinizden emin misiniz", "Personel", MessageBoxButtons.YesNo);
                
                
                if (dialogResult == DialogResult.Yes)
                {

                        personelSil();
                        personelTemizle();
                   
                   
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçiniz...");
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {

            personelTemizle();

        }
    }
}


