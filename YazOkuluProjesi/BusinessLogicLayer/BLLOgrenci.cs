using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.FOTOGRAF != null && p.SIFRE != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListele();
        }

        public static bool  BLLSil(int p)
        {
            if (p >= 0) 
            {
                return DALOgrenci.OgrenciSil(p);

            }
            return false;
        }

        public static List<EntityOgrenci> BLLOgrenciDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool BLLOgrenciGuncelle(EntityOgrenci p)
        {
            if (p.AD != null && p.AD == "" && p.SOYAD != null && p.SOYAD == "" && p.NUMARA != null && p.NUMARA == "" && p.FOTOGRAF != null && p.FOTOGRAF == "" && p.SIFRE != null && p.SIFRE == "" && p.ID > 0) 
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
