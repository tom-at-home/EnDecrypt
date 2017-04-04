using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecrypt
{
    class Caesar : ICrypt
    {
        private string key;
        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public Caesar(string key)
        {
            this.Key = key;
        }

        public void Set(List<char> list)
        {
            
        }

        public void Crypt()
        {
            
        }

        public void Uncrypt()
        {
            
        }
    }
}
