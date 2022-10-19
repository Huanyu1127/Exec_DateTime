using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {//計算圖書下個月歸還時間
            Console.Write("請輸入書籍借閱日期(西元年/月/日)：");
            DateTime lendDate = Convert.ToDateTime(Console.ReadLine());
            DateTime backDate = lendDate.AddMonths(1);
            string backDateDisplay = backDate.ToString("yyyy/MM/dd");
            Console.WriteLine(backDateDisplay);

            Console.WriteLine($"{backDate:yyyy/MM/dd}");
        }
    }
}
