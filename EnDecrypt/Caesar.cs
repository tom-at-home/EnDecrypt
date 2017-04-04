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

        private List<char> list;

        public Caesar(string key)
        {
            this.key = key;
        }

        public void Set(List<char> list)
        {
            this.list = list;
        }

        public void Crypt()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list); list[i] = 'A';
            }
        }

        public void Uncrypt()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = 'B';
            }
        }
    }
}
