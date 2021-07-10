using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebserviceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange fil från skrivbordet");
            String filename = Console.ReadLine();
            WebService3 webService = new WebService3();
            Console.WriteLine(webService.rentacar(filename));
            Console.ReadLine();
        }
    }
}
