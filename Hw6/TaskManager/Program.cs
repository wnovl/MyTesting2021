using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("ID:\t\tName\n");
          Output();
          Console.WriteLine("\nВыберете действие");
          Console.WriteLine("1) Kill by Name");
          Console.WriteLine("2) Kill by ID");
          Console.WriteLine("3) Exit");
          var input = int.Parse(Console.ReadLine());
          Choose(input);
          Console.ReadLine();
        }

        static void Output()
        {
            foreach (var process in Process.GetProcesses())
            {
                Console.WriteLine($"{process.Id}\t\t{process.ProcessName}");
            }  
        }
        static void Choose(int cK)
        {
            Process myprocess = new Process();
            var IsExit = true;
            while (IsExit)
            {
                switch (cK)
                {
                    case 1:
                    Console.WriteLine("Введите имя процесса, который нужно завершить.");
                    var name = Console.ReadLine();
                    foreach (var process in Process.GetProcesses())
                    {
                        if (process.ProcessName == name)
                        {
                            process.Kill();
                            Console.WriteLine("Процесс был успешно завершен.");
                            break;
                        }
                    }
                        break;
                    case 2:
                        Console.WriteLine("Введите ID процесса, который нужно завершить.");
                        var id = int.Parse(Console.ReadLine());
                        foreach (var process in Process.GetProcesses())
                        {
                            if (process.Id == id)
                            {
                                process.Kill();
                                Console.WriteLine("Процесс был успешно завершен.");
                                break;
                            }
                        }
                        break;
                    case 3:
                        IsExit = false;
                        break;
                }
            }

        }

    }
}
