using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreLearn.Utilities.Exceptions
{
    [Serializable]
    public class EShopException : Exception
    {
        public EShopException()
        {

        }

        public EShopException(string message):base(message)
        {

        }
    }
}
