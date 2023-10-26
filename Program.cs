using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssistedProject4
{
    internal class Program
    {


        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {
            string mary = "Mary had a little lamb.";
            Console.WriteLine("Original string=" + mary);
            Console.WriteLine("Clone of a string =" + mary.Clone());
            Console.WriteLine("Compare two strings =" + mary.CompareTo("Mary had a big lamb"));
            Console.WriteLine("ppercase =  "+ mary.ToUpper());
            Console.WriteLine("Insert string within a string =" + mary.Insert(4, " and Jack "));
            Console.WriteLine("Splitting string into words:");
            string[] parts = mary.Split( );
            foreach (string p in parts)
            {
                Console.WriteLine(p);
            }

            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}

