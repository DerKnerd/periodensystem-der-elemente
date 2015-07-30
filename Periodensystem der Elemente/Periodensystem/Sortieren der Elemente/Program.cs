using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Periodensystem_2;

namespace Sortieren_der_Elemente
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementeCollection elem = new ElementeCollection();
            foreach (Element item in Elemente.elemente)
            {
                elem.Add(item);
            }
            elem.Sort();
            Console.WriteLine("Dateinamen angeben");
            string a = Console.ReadLine();
            FileStream fs = new FileStream(@"C:\Users\Kirk.Kirk01\Documents\Visual Studio 2010\Projects\Periodensystem der Elemente\Periodensystem der Elemente\Periodensystem der Elemente 2\Pages\", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(elem.ToString());
        }
    }
}
