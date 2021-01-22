using System;

namespace MyDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string, int> MyList = new MyDictionary<string, string, int>();
            MyList.Add("Atakan", "Çiğdem", 19);
            MyList.Add("Melek", "Gül", 46);
            MyList.Add("Furkan", "Çiğdem", 29);
            int i = 0;

            foreach (var firstNames in MyList.Tfirsts)
            {
                i = i + 1;
                Console.WriteLine("Kişiler {0}. Adı : {1}" , i, firstNames);  
            }
            i = 0;
            foreach (var lastNames in MyList.Tlast)
            {
                i = i + 1;
                Console.WriteLine("Kişiler {0}. Soyadı : {1} ", i, lastNames);
            }
            i = 0;
            foreach (var age in MyList.Tage)
            {
                i = i + 1;
                Console.WriteLine("Kişiler {0}. Yaşı : {1} ", i, age);
            }

            // output ==>

            // Kişiler 1. Adı : Atakan
            // Kişiler 2. Adı : Melek
            // Kişiler 3. Adı : Furkan
            // Kişiler 1. Soyadı : Çiğdem
            // Kişiler 2. Soyadı : Gül
            // Kişiler 3. Soyadı : Çiğdem
            // Kişiler 1. Yaşı : 19
            // Kişiler 2. Yaşı : 46
            // Kişiler 3. Yaşı : 29

        }
    }
}
