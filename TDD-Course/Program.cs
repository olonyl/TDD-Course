using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = NaiveCanonicalizer.GetCanonicalForm(" katie melua life wonderfuL ");
            Console.WriteLine(empty == "");
            empty = NaiveCanonicalizer.GetCanonicalForm(" ");
            Console.WriteLine(empty == "");
            empty = NaiveCanonicalizer.GetCanonicalForm("   ");
            Console.WriteLine(empty == "");


            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm(" katie melua life wonderfuL "));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("katie      Melua    life   Wonderful   "));

            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Wonderful Life katie Melua"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Life Wonderful katie Melua"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("katie Melua life Wonderful"));

            Console.Read();
        }
    }
}
