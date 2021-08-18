using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TranslatorLibrary
{
    public class Libra
    {
        public Dictionary<string, string> dictionary= new Dictionary<string, string>();

        public void Add(string word, string translation)
        {
            dictionary.Add(word, translation);
        }
        
        public void DictionaryFromFile(string path)
        {
            var doc = new StreamReader(path);
            while (doc.Peek() >=0)
            {
                var str = doc.ReadLine();
                var pair = str.Split(" - ");
                Add(pair[0],pair[1]);
            }
        }

        public void DictionaryFromJson(string path)
        {
            var text = File.ReadAllText(path);
            var mydictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
            foreach (var pair in mydictionary)
            {
                dictionary.Add(pair.Key, pair.Value);
                Console.WriteLine($"{pair.Key}-{pair.Value}");
            }
        }

        public void WriteToJson(string path)
        {
            using (FileStream jsonFile = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                var bites = Encoding.UTF8.GetBytes(json);
                jsonFile.Write(bites);
            }
        }
    }
}