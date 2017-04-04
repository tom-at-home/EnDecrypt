using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecrypt
{
    interface ICrypt
    {
        void Set(List<char> list);
        void Crypt();
        void Uncrypt();
    }
}
