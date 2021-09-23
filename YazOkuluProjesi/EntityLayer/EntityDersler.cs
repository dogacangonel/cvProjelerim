using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDersler
    {
        private int id;
        public int ID 
        {
            get { return id; }
            set { id = value; }
        }

        private string dersAd;
        public string DERSAD
        {
            get { return dersAd; }
            set { dersAd = value; }
        }

        private short dersKontenjanMin;
        public short DERSKONTENJANMIN
        {
            get { return dersKontenjanMin; }
            set { dersKontenjanMin = value; }
        }

        private short dersKontenjanMax;
        public short DERSKONTENJANMAX
        {
            get { return dersKontenjanMax; }
            set { dersKontenjanMax = value; }
        }
    }
}
