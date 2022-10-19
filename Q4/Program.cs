using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {//取得本月最後一天
            DateTime today=DateTime.Today;
            var todayLastDay=DateTime.DaysInMonth(today.Year, today.Month);

			string todayLastDayDisplay=$"{today.Month}/{todayLastDay}";
            Console.WriteLine(todayLastDayDisplay);

		}
    }
}
