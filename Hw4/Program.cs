using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CharNamespace();


            string data = RecieveData();
            List<string> parts = SplitData(data);
            List<int> numbers = TransformData(parts);
            int result = CalculateData(numbers);
            DisplayOutput(result);

            
            Console.WriteLine("Введите порядковый номер месяца");
            
            Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            

            {
                Console.Write("n=");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                    Console.WriteLine("Число A{0} = {1}", i, Fiban(i));
                Console.ReadLine();
            }
            int Fiban(int n)
            {
                if (n == 1 || n == 2) return 1;
                else return Fiban(n - 1) + Fiban(n - 2);
            }

            Console.ReadLine();
        }

        static void CharNamespace()
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                string firstName = Console.ReadLine();
                Console.WriteLine("Введите Отчество");
                string patronymic = Console.ReadLine();
                Console.WriteLine(GetFullName(lastName, firstName, patronymic));
                return;
            }
        }
        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }

        
        static string RecieveData()
        {
            Console.Write("Введите строку — набор чисел, разделенных пробелом: ");
            return Console.ReadLine();
        }
        static List<string> SplitData(string data)
        {
            List<string> parts = new List<string>();
            if (string.IsNullOrWhiteSpace(data))
            {
                return parts;
            }
            parts.AddRange(data.Split(' '));
            return parts;
        }

        static List<int> TransformData(List<string> parts)
        {
            List<int> numbers = new List<int>();
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        static int CalculateData(List<int> numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

        static void DisplayOutput(int result)
        {
            Console.WriteLine("Сумма чисел : " + result);
        }


        public enum Months
        {
            Jan = 1,
            Feb = 2,
            March = 3,
            Apr = 4,
            May = 5,
            Jun = 6,
            Jul = 7,
            Aug = 8,
            Sep = 9,
            Oct = 10,
            Nov = 11,
            Dec = 12,
        }
        enum season { NaN, Winter, Spring, Summer, Autumn }
        static season OfMonth(int monthEnum)
        {
            
            
                if (monthEnum >= 0 && monthEnum < 12)
                   

                switch ((monthEnum % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }

                else

                {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return season.NaN;
                }
                
           
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        static void monthEnum()
        {
            string month = Console.ReadLine();
            int userMonthsInt = Convert.ToInt32(month);
            Months monthEnum = (Months)userMonthsInt;
            switch (monthEnum)
            {
                case Months.Jan: Console.WriteLine("January"); break;
                case Months.Feb: Console.WriteLine("February"); break;
                case Months.March: Console.WriteLine("March"); break;
                case Months.Apr: Console.WriteLine("April"); break;
                case Months.May: Console.WriteLine("May"); break;
                case Months.Jun: Console.WriteLine("June"); break;
                case Months.Jul: Console.WriteLine("July"); break;
                case Months.Aug: Console.WriteLine("August"); break;
                case Months.Sep: Console.WriteLine("September"); break;
                case Months.Oct: Console.WriteLine("October"); break;
                case Months.Nov: Console.WriteLine("November"); break;
                case Months.Dec: Console.WriteLine("December"); break;
            }
            
        }
        

}
    
}
