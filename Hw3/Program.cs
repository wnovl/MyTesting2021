using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите размер двумерного массива M на N");
                Console.WriteLine("Введите m");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите n");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[m, n];
                int next_string = 0;
                Random rnd = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(0, 10);
                        Console.WriteLine($"{new string(' ', next_string)}{array[i, j]}");
                        next_string++;
                    }
                }
            }

            {
                string[,] phoneList = new string[5, 2];
                Console.Write("Имя:");

                Console.Write("        Номер телефона / email:");
                Console.WriteLine();

                for (int i = 0; i < phoneList.GetLength(0); i++)
                {
                    for (int j = 0; j < phoneList.GetLength(1); j++)
                    {
                        string name = Console.ReadLine();
                        string number = Console.ReadLine();
                        phoneList[i, j] = string.Format("{0}        {1}", name, number);
                        Console.WriteLine(phoneList[i, j]);
                        break;
                    }
                    Console.WriteLine();
                }



                {
                    string s;
                    while ((s = Console.ReadLine()) != null)
                        Console.WriteLine(new string(s.Reverse().ToArray()));
                }


            }

            {
                string[,] hw = new string[10, 10];

                

                
                for (int i = 0; i < hw.GetLength(0); i++)
                {
                    for (int j = 0; j < hw.GetLength(1); j++)
                    {

                        bool bj = ((i == 5) && (j == 1));
                        bool bk = ((i == 4) && (j == 5));
                        bool bt = ((i == 5) && (j == 5)) || ((i == 6) && (j == 5));
                        bool bm = ((i == 1) && (j == 1)) || ((i == 2) && (j == 1));
                        bool bl = bm || bj || bk || bt;
                        if (bl)
                        {
                            hw[i, j] = "x";
                            Console.Write(hw[i, j] + " ");
                        }
                        else
                        {
                            hw[i, j] = "0";
                            Console.Write(hw[i, j] + " ");
                        }


                    }
                    Console.WriteLine();
                }

            }
            Console.ReadLine();




        }
    }
}
