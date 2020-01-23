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
            List<int> integers = new List<int>() { 1 };
            Console.WriteLine(integers.Capacity);
            Console.ReadLine();

        }
    }
}
