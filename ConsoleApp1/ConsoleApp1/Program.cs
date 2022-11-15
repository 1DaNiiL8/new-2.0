using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок вклада в месяцах: ");
            int period = Convert.ToInt32(Console.ReadLine());
            int i;
            do 
            {
                i += i;
                sum += sum * 0.07M;
            }
            while (i <= 100) ;
            Console.WriteLine("После  " + period  +  "  месяцев сумма вклвдов составит  " + sum);
            Console.ReadKey();

        }
    }
}
