using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonnyZoznam telefonnyZoznam = new TelefonnyZoznam();
            telefonnyZoznam.PridajStudenta(new Student { TelCislo = "0905 474147", Meno = "Fero", RC = "014547/4748" });
            telefonnyZoznam.PridajStudenta(new Student { TelCislo = "0903 476147", Meno = "Jozo", RC = "150678/4648" });
            telefonnyZoznam.PridajStudenta(new Student { TelCislo = "0903 476145", Meno = "Mara", RC = "151678/4648" });

            Student student = new Student();
            if (telefonnyZoznam.Find("014547/4748", out student))
            {
                Console.WriteLine(student.Meno);
                Console.WriteLine(student.TelCislo);
            }
            else
            {
                Console.WriteLine("Hodnota nenajdena");
            }
            Console.ReadLine();
        }
    }
}
