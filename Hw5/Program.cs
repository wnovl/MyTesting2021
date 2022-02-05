using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            txt();
            binTxt();
            katalog();
        }
        static void txt()
        {
            Console.WriteLine("Введите текст");
            string userText = Console.ReadLine();
            File.WriteAllText(path: "readme.txt", contents: userText);
            File.AppendAllText(path: "readme.txt", contents: DateTime.Now.ToString());
        }
        static void binTxt()
        {
            Console.WriteLine("Введите количество чисел");
            byte n = byte.Parse(Console.ReadLine());
            byte[] mas = new byte[n];
            Console.WriteLine("Введите эти числа в промежутке от 0 до 255");

            for (int i = 0; i < n; i++)
            {
                mas[i] = byte.Parse(Console.ReadLine());
            }
            File.WriteAllBytes("bytes.bin", mas);
        }
        static void katalog()
        {
            string workDir = @"D:\ExampleDir";
            Console.WriteLine(Directory.Exists(workDir));
            string notesDir = Path.Combine(workDir, "Nt");
            Directory.CreateDirectory(notesDir);
            string noteText = "ТЕКСТ";
            string notePath = Path.Combine(notesDir, "Nt 1.txt");
            File.WriteAllText(notePath, noteText);
        }
    }
}
