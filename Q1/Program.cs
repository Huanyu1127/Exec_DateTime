using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Q1計算三天後 DVD 應歸還時間
            Console.Write("請輸入DVD借閱日期(西元年/月/日)：");
            DateTime lendDate = Convert.ToDateTime(Console.ReadLine());
            DateTime backDate = lendDate.AddDays(3);
            string backDateDisplay = backDate.ToString("yyyy/MM/dd");
            Console.WriteLine(backDateDisplay);

            Console.WriteLine($"{backDate:yyyy/MM/dd}");
        }
    }
}
