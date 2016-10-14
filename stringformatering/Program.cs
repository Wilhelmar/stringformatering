using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringformatering
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1
            Console.WriteLine("Övning 1:");
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString("d"));
            Console.ReadLine();
            //Övning 2
            
            Console.WriteLine("Övning 2:");
           
            Console.WriteLine("Vi ska räkna ut en cirkels area med 4 decimaler!");
            var area = 4 * 4 * Math.PI;
            Console.WriteLine("Vi tar 4 x 4 x PI = " + area.ToString("F4"));
            Console.WriteLine("Det var lätt! Nu går vi vidare! =)");
            Console.ReadLine();

            //Övning 3

            Console.WriteLine("Övning 3:");

            int tal = 1000000000;

            Console.WriteLine("{0:0,0,0}", tal);
            Console.ReadLine();

            //Övning 4

            double value = 123.00;

            Console.WriteLine("Det blir " + "{0}",value + "kr och 00 öre");
            

            //Övning 5

            Console.WriteLine("Övning 5:");

            Console.WriteLine("Mata in ditt fulla personnummer: ");
            var pnmr = double.Parse(Console.ReadLine());

            Console.WriteLine(pnmr.ToString("####-##-##-####"));

            Console.ReadLine();

            //Övning 6
            Console.WriteLine("Övning 6:"); 





        }
    }
}
