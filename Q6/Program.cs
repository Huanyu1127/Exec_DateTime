using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {//根據日期, 傳回今天是本月的上旬, 中旬或下旬
            DateTime today = DateTime.Today;
            int todayDay = today.Day;

			if (todayDay >=1&& todayDay <= 10)
            {
                Console.WriteLine("今天是本月的上旬");
            }
            else if (todayDay >10 && todayDay <= 20)
            {
				Console.WriteLine("今天是本月的中旬");
			}
            else
            {
                Console.WriteLine("今天是本月的下旬");
            }

		}
    }
}
