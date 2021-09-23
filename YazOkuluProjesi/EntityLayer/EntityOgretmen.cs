using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string adSoyad;
        public string ADSOYAD
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        private int brans;
        public int BRANS
        {
            get { return brans; }
            set { brans = value; }
        }
    }
}
