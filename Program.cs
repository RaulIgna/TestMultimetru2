using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agilent_34411A_LIB;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agilent_34411A_LIB.DMM34410A a = new DMM34410A("4614");
            var er = Agilent_34411A_LIB.Agilent_34465A_LIB.Open(a);
            if (!er.OK)
            {
                Console.WriteLine("nu e ok");
                Console.WriteLine(er.Str_Error);
            }
            else
            {
                Console.WriteLine("e ok");
            }
        }
    }
}
