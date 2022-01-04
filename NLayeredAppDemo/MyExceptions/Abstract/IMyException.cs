using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions.Abstract
{
    public interface IMyException
    {
        void HandleException(Action action);
    }
}
