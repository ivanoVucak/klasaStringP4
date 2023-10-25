
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("Unesi niz znakova: ");
            tekst = Convert.ToString(Console.ReadLine());

            string[] rijeci = tekst.Split(' ');
           
            Console.Write(rijeci.First() + " ");
            Console.WriteLine(rijeci.Last());

            Console.ReadKey();
        }
    }
}
