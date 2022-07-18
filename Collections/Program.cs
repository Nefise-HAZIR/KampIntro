using System;
using System.Collections.Generic;

namespace Collections // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>() {"a","b","c" };
            isimler.Add("d");
            foreach (string s in isimler)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}