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
                Console.WriteLine("Kişiler {0}. Soyadı : {1} ", i, age);
            }
        }
    }
}
