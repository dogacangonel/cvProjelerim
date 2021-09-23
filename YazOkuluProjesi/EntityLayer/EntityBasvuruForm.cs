using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basId;
        public int BASID
        {
            get { return basId; }
            set { basId = value; }
        }

        private int basOgrenciId;
        public int BASOGRENCIID
        {
            get { return basOgrenciId; }
            set { basOgrenciId = value; }
        }

        private int basDersId;
        public int BASDERSID
        {
            get { return basDersId; }
            set { basDersId = value; }
        }


    }
}
