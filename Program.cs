using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Unesi neku recenicu: ");
            string s1= Console.ReadLine();

            string[] sRijec = s1.Split(' ');
            

            Console.WriteLine("Prva rijec je: " + sRijec[0]);
            Console.WriteLine("Prva rijec je: " + sRijec[sRijec.Length-1]);

            Console.ReadKey();
        }
    }
}
