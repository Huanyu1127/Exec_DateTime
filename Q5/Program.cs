using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {//列出指定年份的每一個星期日
            Console.Write("請輸入指定年份：");
            string input = Console.ReadLine();
            //pre condition
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入");
                return;
            }
            int yearnumber = Convert.ToInt32(input);

            //找出該年的第一個星期日 並做迴圈+7
            DateTime YearFirstDay = new DateTime(yearnumber, 01, 01);
            int firstDay = (int)YearFirstDay.DayOfWeek;

            DateTime result = YearFirstDay;

            switch (firstDay)
            {
                case 0:
                    break;
                case 1:
                    result = YearFirstDay.AddDays(6);
                    break;
                case 2:
                    result = YearFirstDay.AddDays(5);
                    break;
                case 3:
                    result = YearFirstDay.AddDays(4);
                    break;
                case 4:
                    result = YearFirstDay.AddDays(3);
                    break;
                case 5:
                    result = YearFirstDay.AddDays(2);
                    break;
                case 6:
                    result = YearFirstDay.AddDays(1);
                    break;
            }
            Console.WriteLine($"您輸入的指定年份第一個星期日是{result:MM/dd}");
            //在第一個星期日+7做迴圈 

            for (DateTime resultDisplay= result; resultDisplay.Year < YearFirstDay.AddYears(1).Year; resultDisplay= resultDisplay.AddDays(7)) {
                
                    Console.WriteLine(resultDisplay);
                
            }            //for(DateTime firstSunday=input; firstSunday)
            
        }
    }
}
