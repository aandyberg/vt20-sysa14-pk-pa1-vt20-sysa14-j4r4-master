using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebserviceConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj något av följande: getAllCars, getAllPersons, getAllOwners, write close to exit the program");
            String userChoice = "";
            WebServiceAssignment4 webService = new WebServiceAssignment4();
            DataSet ds = new DataSet();
            //bool userWantsExit = false;
            while (true)
            {
                userChoice = Console.ReadLine();
                if (userChoice.Equals("getAllCars"))
                {
                    foreach (var item in webService.getAllCarsJava())
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else if (userChoice.Equals("getAllPersons"))
                {
                    foreach (var item in webService.getAllPersonsJava())
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else if (userChoice.Equals("getAllOwners"))
                {
                    foreach (var item in webService.getAllOwnerJava())
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else if (userChoice.Equals("close"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel kommando");
                }
                //Console.ReadLine();
            }
            Environment.Exit(0);
        }
    }
}
