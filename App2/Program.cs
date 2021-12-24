using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App2
{
    class Program

    {
        static void Main(string[] args)

        {  
            double a;
            double b;
            System.Console.WriteLine("Введите минимальную температуру за сегодня");
            a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Введите максимальную температуру за сегодня");
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            c = (a + b) / 2;
            bool bN = c > 0;
            System.Console.WriteLine($"Средняя температура за сегодня = {c}");
            System.Console.WriteLine("Введите порядковый номер текущего месяца");
            int month = Convert.ToInt32(Console.ReadLine());

            string monthTitle = "";
            switch(month)
            {
                case 1:
                    { monthTitle = "Январь";break;}
                case 2:
                    {monthTitle = "Февраль";break;}
                case 3:
                    {monthTitle = "Март";break;}
                case 4:
                    {monthTitle = "Апрель";break;}
                case 5:
                    {monthTitle = "Май";break;}
                case 6:
                    {monthTitle = "Июнь";break;}
                case 7:
                    {monthTitle = "Июль";break;}
                case 8:
                    {monthTitle = "Август";break;}
                case 9:
                    { monthTitle = "Сентябрь";break;}
                case 10:
                    {monthTitle = "Октябрь";break; }
                case 11:
                    {monthTitle = "Ноябрь";break;}
                case 12:
                    { monthTitle = "Декабрь";break;}
            }

            bool zT = ((month == 1) || (month == 2) || (month == 12)) && bN ;
            if (zT == true)
            {System.Console.WriteLine(monthTitle);
             System.Console.WriteLine("Дождливая зима");}
            else
            {System.Console.WriteLine(monthTitle); }

            if ((month % 2) == 0) 
            {System.Console.WriteLine("Четное");}
            else
            {System.Console.WriteLine("Нечетное");}

            string sN = "OOO REVAlution";
            string stroka2 = "115478 Москва Каширское ш.25 стр.17 ";
            string PHKKT = "PH KKT:411132712312371371";
            DateTime date = DateTime.Now;
            string ZHKKT = "ЗH KKT:";
            long ZT2 = 312312546466456787;
            string ZT3 = "СМЕНА:777 ЧЕК:1";
            string stroka5 = "КАССОВЫЙ ЧЕК/ПРИХОД";
            string stroka6 = "ИНН:7724548394                      ФН:923124124";
            string cashierName = "Кассир: Колотушка Зинаида Перкосраковна    #4126";
            string stroka8 = "Баларпан";
            string stroka9 = "|                                          1 x 777 |";
            string stroka10 = "| 1                                           =777 |";
            string stroka11 = "|                                            Товар |";
            string stroka12 = "| БЕЗ НАЛОГА                                       |";
            string stroka13 = "| ИТОГ                                         777 |";
            System.Console.WriteLine("|==================================================|");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine($"| {sN}                                   |");
            System.Console.WriteLine($"| {stroka2}             |");
            System.Console.WriteLine($"| {PHKKT}    {date} |");
            System.Console.WriteLine($"| {ZHKKT}{ZT2}        {ZT3} |");
            System.Console.WriteLine($"| {stroka5}                              |");
            System.Console.WriteLine($"| {stroka6} |");
            System.Console.WriteLine($"| {cashierName} |");
            System.Console.WriteLine($"| {stroka8}                                         |");
            System.Console.WriteLine($"{stroka9}");
            System.Console.WriteLine($"{stroka10}");
            System.Console.WriteLine($"{stroka11}");
            System.Console.WriteLine($"{stroka12}");
            System.Console.WriteLine($"{stroka13}");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine("|                                                  |");
            System.Console.WriteLine("|==================================================|");  
              

            System.Console.WriteLine("Введите количество рабочих дней");

            int workDays = Convert.ToInt32(Console.ReadLine());
                                  
            switch(workDays)
            {
                case 1:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        break; }
                case 2:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r = Console.ReadLine();
                        string t = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        System.Console.WriteLine(t);
                        break; }
                case 3:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r = Console.ReadLine();
                        string t = Console.ReadLine();
                        string y = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        System.Console.WriteLine(t);
                        System.Console.WriteLine(y);
                        break; }
                case 4:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r = Console.ReadLine();
                        string t = Console.ReadLine();
                        string y = Console.ReadLine();
                        string u = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        System.Console.WriteLine(t);
                        System.Console.WriteLine(y);
                        System.Console.WriteLine(u);
                        break; }
                case 5:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r = Console.ReadLine();
                        string t = Console.ReadLine();
                        string y = Console.ReadLine();
                        string u = Console.ReadLine();
                        string i = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        System.Console.WriteLine(t);
                        System.Console.WriteLine(y);
                        System.Console.WriteLine(u);
                        System.Console.WriteLine(i);
                        break; }
                case 6:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r= Console.ReadLine();
                        string t = Console.ReadLine();
                        string y = Console.ReadLine();
                        string u = Console.ReadLine();
                        string i = Console.ReadLine();
                        string o = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        System.Console.WriteLine(t);
                        System.Console.WriteLine(y);
                        System.Console.WriteLine(u);
                        System.Console.WriteLine(i);
                        System.Console.WriteLine(o);
                        break; }
                case 7:
                    {
                        System.Console.WriteLine("Введите рабочие дни недели офиса");
                        string r = Console.ReadLine();
                        string t = Console.ReadLine();
                        string y = Console.ReadLine();
                        string u = Console.ReadLine();
                        string i = Console.ReadLine();
                        string o = Console.ReadLine();
                        string p = Console.ReadLine();
                        System.Console.WriteLine("Офис работает по этим дням:");
                        System.Console.WriteLine(r);
                        System.Console.WriteLine(t);
                        System.Console.WriteLine(y);
                        System.Console.WriteLine(u);
                        System.Console.WriteLine(i);
                        System.Console.WriteLine(o);
                        System.Console.WriteLine(p);
                        break; }
            }
            System.Console.ReadLine();
           
        }
       
    }
}


