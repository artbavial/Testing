using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Привет");
            list.Add(" мой друг!");
            list.Add(" Как поживаешь?\n");

            foreach(var n in list)
            {
                Console.Write(n);
            }
        }
    }
}
