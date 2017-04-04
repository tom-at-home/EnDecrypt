using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "World";
            MyList list = new MyList(new Caesar(key));
            list.Add('H');
            list.Add('e');
            list.Add('l');
            list.Add('l');
            list.Add('o');
            Console.WriteLine(list);
            list.Crypt();
            Console.WriteLine(list);
            list.Uncrypt();
            Console.WriteLine(list);

            MyList list2 = new MyList(new Scrumble());
            list2.Add('H');
            list2.Add('e');
            list2.Add('l');
            list2.Add('l');
            list2.Add('o');
            Console.WriteLine(list2);
            list2.Crypt();
            Console.WriteLine(list2);
            list2.Uncrypt();
            Console.WriteLine(list2);

            Console.ReadLine();
        }
    }
}
