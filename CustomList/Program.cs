using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "Mary ", "Murphy ", "Dave " };
            Console.WriteLine(strings[0] + strings[1] + strings[2]);
            Console.ReadLine();

        }
    }
}
