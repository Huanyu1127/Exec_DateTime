using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {//取得本月一日
            DateTime today=DateTime.Today;
            string todayMonthOne = today.ToString("MM/01");
            Console.WriteLine(todayMonthOne);

			Console.WriteLine($"{today:MM}/01");
		}
    }
}
