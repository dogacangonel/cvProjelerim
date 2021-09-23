using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDersler
    {
        public static List<EntityDersler> ListeleBLL()
        {
            return DALDers.DersListele();
        }

        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if (p.BASDERSID>=0 && p.BASOGRENCIID>=0 )
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
        
    }
}
