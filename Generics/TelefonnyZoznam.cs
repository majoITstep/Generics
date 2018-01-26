using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TelefonnyZoznam
    {
        Dictionary<string, Student> zoznam = new Dictionary<string, Student>();

        public void PridajStudenta(Student student)
        {
            try
            {
                zoznam.Add(student.TelCislo, student);
            }
            catch ( Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
           
            zoznam.Add(student.RC, student);
        }

        public bool Find(string telCislo, out Student student)
        {
            return zoznam.TryGetValue(telCislo, out student);
        }
    }
}
