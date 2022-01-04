using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.MyExceptions
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
            catch
            {

                throw new MyException("İşlem Gerçekleştirilemedi");
            }
        }
    }
}
