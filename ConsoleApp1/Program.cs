using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine(rand.Next(0,3));
            }
        }
    }
}
