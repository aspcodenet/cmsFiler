using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var s = System.IO.File.OpenText("c:\\kurser\\hopp.txt"))
            {
                var alltext = s.ReadToEnd();
                Console.WriteLine(alltext);
            }
        }
    }
}
