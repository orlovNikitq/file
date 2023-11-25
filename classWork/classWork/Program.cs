using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            string path = @"C:\Users\zunderz\Documents\qtinstaller\qwerty";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Директория создана.");
            }

            string file1 = Path.Combine(path, "file1.txt");
            string file2 = Path.Combine(path, "file2.txt");

            File.WriteAllText(file1, "Это содержимое файла.");
            File.WriteAllText(file2, "Это содержимое файла.");
            Console.WriteLine("Введите слово для поиска в файлах:");
            string word = Console.ReadLine();

            string[] files = Directory.GetFiles(path);

            foreach (var el in files)
            {
                string fileContent = File.ReadAllText(el);
                if (fileContent.Contains(word))
                    Console.WriteLine($"Слово '{word}' найдено в файле: {el}");
                else
                    Console.WriteLine($"Слово '{word}' не найдено в файле: {el}");
                
            }
            */
            /*
            string str = "Hi! My name is Elena, im living in Pushkin street, 23! I'm 19 years old!";
            string pattern = "[0-9\\W]";
            string result = Regex.Replace(str, pattern, " ");
            Console.WriteLine(result);
            */
        }
    }
}