using System;
using TranslatorLibrary;

namespace TranslatorPj
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Libra();
            dict.DictionaryFromFile("D:/dict.txt");
            
            //dict.CreateJson();
            /*try
            {
                Console.WriteLine(Translator.Translate(dict.dictionary, "солнце"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Перевод не найден. Добавьте перевод");
                var key = Console.ReadLine();
                var val = Console.ReadLine();
                dict.Add(key, val);
            }*/
           // Console.WriteLine(Translator.GiveMeKey(dict, "apple"));
            dict.DictionaryFromJson("D:/newjsom.json");
            Console.WriteLine();
            Console.WriteLine(Translator.GiveMeKey(dict, "predicate"));
            Console.ReadLine();
        }
    }
}