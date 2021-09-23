using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parameters)
        {
            SqlCommand com = new SqlCommand("Insert into TBLOGRENCI (ogrAd,ogrSoyad,ogrNumara,ogrFotograf,ogrSifre) values(@p1,@p2,@p3,@p4,@p5)", Connection.con);
            if (com.Connection.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }
            com.Parameters.AddWithValue("@p1", parameters.AD);
            com.Parameters.AddWithValue("@p2", parameters.SOYAD);
            com.Parameters.AddWithValue("@p3", parameters.NUMARA);
            com.Parameters.AddWithValue("@p4", parameters.FOTOGRAF);
            com.Parameters.AddWithValue("@p5", parameters.SIFRE);
            return com.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListele()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand com = new SqlCommand("Select * from TBLOGRENCI", Connection.con);
            if (com.Connection.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }
            SqlDataReader da = com.ExecuteReader();

            while (da.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(da["ogrId"]);
                ent.AD = da["ogrAd"].ToString();
                ent.SOYAD = da["ogrSoyad"].ToString();
                ent.NUMARA = da["ogrNumara"].ToString();
                ent.FOTOGRAF = da["ogrFotograf"].ToString();
                ent.SIFRE = da["ogrSifre"].ToString();
                ent.BAKIYE = Convert.ToDouble(da["ogrBakiye"]);
                degerler.Add(ent);
            }
            Connection.con.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parameter)
        {
            SqlCommand com = new SqlCommand("Delete from TBLOGRENCI Where ogrId=@p1", Connection.con);
            if (Connection.con.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }
            com.Parameters.AddWithValue("@p1", parameter);
            return com.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand com = new SqlCommand("Select * from TBLOGRENCI where ogrId=@p1", Connection.con);
            com.Parameters.AddWithValue("@p1", id);
            if (com.Connection.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }
            SqlDataReader da = com.ExecuteReader();

            while (da.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = da["ogrAd"].ToString();
                ent.SOYAD = da["ogrSoyad"].ToString();
                ent.NUMARA = da["ogrNumara"].ToString();
                ent.FOTOGRAF = da["ogrFotograf"].ToString();
                ent.SIFRE = da["ogrSifre"].ToString();
                ent.BAKIYE = Convert.ToDouble(da["ogrBakiye"].ToString());
                degerler.Add(ent);
            }
            Connection.con.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci p)
        {
            SqlCommand com = new SqlCommand("Update TBLOGRENCI set ogrAd=@p1,ogrSoyad=@p2,ogrNumara=@p3,ogrFotograf=@p4,ogrSifre=@p5 where ogrId=@p6", Connection.con);
            if (Connection.con.State!=ConnectionState.Open)
            {
                Connection.con.Open();
            }
            com.Parameters.AddWithValue("@p1", p.AD);
            com.Parameters.AddWithValue("@p2", p.SOYAD);
            com.Parameters.AddWithValue("@p3", p.NUMARA);
            com.Parameters.AddWithValue("@p4", p.FOTOGRAF);
            com.Parameters.AddWithValue("@p5", p.SIFRE);
            com.Parameters.AddWithValue("@p6", p.ID);
            return com.ExecuteNonQuery() > 0;

        }
    }
}
