using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {//根據不同時間, 傳回不同問安方式 早0-11 午12-18 晚19-23
            Console.Write("請輸入日期和時間(西元年/月/日 時:分:秒)：");
            DateTime input=Convert.ToDateTime(Console.ReadLine());
            int inputTime=input.Hour;
            if (inputTime >= 0 && inputTime <= 11)
            {
                Console.WriteLine($"您輸入的時間是{input}，早安");
            }
			else if (inputTime >11 && inputTime <= 18)
			{
				Console.WriteLine($"您輸入的時間是{input}，午安");
			}
			else
			{
				Console.WriteLine($"您輸入的時間是{input}，晚安");
			}
		}
    }
}
