using System;

namespace HomeWork2
{
    public class Program
    {
        // برنامه ای بنویسید که یک عدد از ورودی گرفته و ان
        // را به عنوان ورودی به یک تابع دهد
        // درون تابع فاکتوریل ان عدد محاسبه شود و نتیجه
        // بازگردانده شده آن را به روال اصلی برنامع برگرد.

        public static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int num = int.Parse(Console.ReadLine());

            int result = Fact(num);

            Console.WriteLine($"\n{num}! = {result}");
        }     
    }
}