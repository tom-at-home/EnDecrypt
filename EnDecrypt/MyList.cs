using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecrypt
{
    class MyList : List<char>
    {
        private ICrypt crypt;

        public MyList(ICrypt crypt)
        {
            this.crypt = crypt;
        }

    }
}
