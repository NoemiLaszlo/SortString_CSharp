using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {        
        
        static void Main(string[] args)
        {
            string w = "Some long string to add to the array";
            string[] words = w.Split(' ');
            Array.Sort(words);
            string s = string.Join(" ", words);
            Console.WriteLine(s);
        }
    }
}
