using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace TranslatorLibrary
{
    public static class Translator
    {
        public static string Translate(Dictionary<string, string> dictionary, string word)
        {
            string translation;
            try
            {
                translation = dictionary[word];
                return translation;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException();
            }
        }

        public static string GiveMeKey(Libra dictionary, string word)
        {
            
            string key = dictionary.dictionary.Where(x => x.Value == word).FirstOrDefault().Key;
            if (key == String.Empty)
            {
                //throw new KeyNotFoundException();
                Console.WriteLine("rty");
                return "qwe";
            }
            else if (key == null)
            {
                Console.WriteLine("zxc");
                throw new KeyNotFoundException();
            }
            else
            {
                
                return key;
            }
        }
        
        public static string ShowWholeDictionary(Dictionary<string, string> dictionary)
        {
            string dict = String.Empty;
            foreach (var pair in dictionary)
            {
                dict += $"{pair.Key} - {pair.Value}";
            }

            return dict;
        }

        public static List<string> GiveMeKeys(Dictionary<string, string> dictionary)
        {
            var keyList = new List<string>();
            foreach (var pair in dictionary)
            {
                keyList.Add(pair.Key);
            }
            return keyList;
        }
        
        public static List<string> GiveMeValues(Dictionary<string, string> dictionary)
        {
            var valueList = new List<string>();
            foreach (var pair in dictionary)
            {
                valueList.Add(pair.Value);
            }
            return valueList;
        }
    }
}