using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyException
{
    public class MyException:Exception
    {
        public MyException(string text):base(text)
        {

        }

        public void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
        }
    }
}
