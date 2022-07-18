// See https://aka.ms/new-console-template for more information
using System;

namespace Donguler // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "a","b","c"
            };
            for(int i=0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
               
            }
            foreach(string s in kurslar)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
