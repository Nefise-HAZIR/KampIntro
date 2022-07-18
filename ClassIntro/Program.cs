using System;

namespace ClassIntro // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs=new Kurs();
            kurs.kursadı = "c#";
            kurs.Egitmen = "engin";
            kurs.IzlenmeOranı = 68;

            Kurs kurs1 = new Kurs();
            kurs1.kursadı = "c++";
            kurs1.Egitmen = "can boz";
            kurs1.IzlenmeOranı = 100;

            Kurs[] kurslar = new Kurs[]
            {
                kurs,kurs1
            };

            foreach (Kurs item in kurslar)
            {
                Console.WriteLine(item.kursadı);
            }

            
        }
    }
    class Kurs
    {
        public string kursadı { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }

}