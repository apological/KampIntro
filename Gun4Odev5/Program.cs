using System;

namespace Gun4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> NameAndAge = new MyDictionary<string, int>();

            NameAndAge.Add("Ahmet", 17);
            NameAndAge.Add("Betül",20);
            NameAndAge.Add("Mustafa",47);
            NameAndAge.Add("İnci",42);

            foreach (var key in NameAndAge.Keys)
            {
                Console.WriteLine(key);
            }

            foreach(var value in NameAndAge.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
