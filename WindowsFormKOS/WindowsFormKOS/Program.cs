using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPersonelTakip.Model;

namespace WindowsFormKOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IDataBase.DataToDataTable("Select * from kullanicilar Where aktif=1").Rows.Count>0)
            {
                Application.Run(new FormLogin());
            }
            else
            {
                Application.Run(new FormKurulum());
                
            }

        }
    }
}
