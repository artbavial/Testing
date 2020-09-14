using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string txt = Console.ReadLine();

                switch (txt)
                {
                    case "Привет":
                        Console.WriteLine("И тебе привет!");
                        break;
                    case "Как дела?":
                        Console.WriteLine("Спасибо, хорошо!");
                        break;
                    default:
                        Console.WriteLine("Такой команды нет.");
                        break;
                }
            }

        }
        
    }
}
