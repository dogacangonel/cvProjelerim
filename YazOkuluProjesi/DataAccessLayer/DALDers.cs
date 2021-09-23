using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDersler> DersListele()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand com = new SqlCommand("Select *from TBLDERSLER", Connection.con);
            if (Connection.con.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.ID = Convert.ToInt32(da["dersId"]);
                ent.DERSAD = da["dersAd"].ToString();
                ent.DERSKONTENJANMIN = Convert.ToInt16(da["dersKontenjanMin"]);
                ent.DERSKONTENJANMAX = Convert.ToInt16(da["dersKontenjanMax"]);
                degerler.Add(ent);
            }
            Connection.con.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm p)
        {
            SqlCommand com = new SqlCommand("Insert Into TBLBASVURU (ogrenciId,dersId) values(@p1,@p2)", Connection.con);
            com.Parameters.AddWithValue("@p1", p.BASOGRENCIID);
            com.Parameters.AddWithValue("@p2", p.BASDERSID);
            if (Connection.con.State!=ConnectionState.Open)
            {
                Connection.con.Open();
            }

            return com.ExecuteNonQuery();
        }



    }
}
