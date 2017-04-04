using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecrypt
{
    class MyList : List<char>, ICrypt
    {
        private ICrypt crypt;

        public MyList(ICrypt crypt)
        {
            this.crypt = crypt;
        }

        public void Crypt()
        {
            this.crypt.Set(this);
            this.crypt.Crypt();
        }

        public void Set(List<char> list)
        {

        }
         
        public void Uncrypt()
        {
            this.crypt.Set(this);
            this.crypt.Uncrypt();
        }

        public override string ToString()
        {
            string ret = "";
            foreach (char item in this)
            {
                ret += item;
            }
            return ret;
;        }

    }
}
