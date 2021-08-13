using System;

namespace Lesson5_12_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ №1
            Console.WriteLine("ДЗ №1");
            Console.WriteLine("Введите а:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = b - a + 1;
            int sum = ((a + b) * n / 2) - a - b;
            Console.WriteLine($"Сумма чисел между {a} и {b} равно: {sum}");
            for (; a < b; a++)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine($"Нечетная значения: {a}");
                }
            }

            // ДЗ №2
            Console.WriteLine("ДЗ №2");
            Console.WriteLine("Введите высоту прямоугольника:");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write("  *");
                }
                Console.WriteLine("  *");
            }
            Console.WriteLine("Введите высоту треугольника:");
            int hе = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hе; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Введите высоту пирамиды:");
            int hеi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hеi; i++)
            {
                for (int j = hеi; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Введите высоту ромба:");
            int hеig = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hеig; i++)
            {
                for (int j = hеig; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < hеig; i++)
            {
                for (int j = -2; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = hеig - 2; j > i; j--)
                {
                    Console.Write("*");
                }
                for (int j = hеig - 1; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            // ДЗ №3
            Console.WriteLine("ДЗ №3");
            Console.WriteLine("Начальная сумма вклада: 1000р");
            start:
            Console.WriteLine("Введите процент:");
            var p = Convert.ToDouble(Console.ReadLine());
            if (p > 25)
            {
                Console.WriteLine("Перевышен лимит процента!!");
                goto start;
            }
            else if (p < 0)
            {
                Console.WriteLine("Процент не должен быть ниже нуля!!");
                goto start;
            }
            double s = 1000;
            int k = 0;
            while (s < 1100)
            {
                s = s + (s * p / 100);
                k++;
                Console.WriteLine($"Месяц {k}: {s}pуб.");

            }
            Console.WriteLine($"Через {k} месяцев размер вклада превысит 1100 руб.");
            Console.WriteLine($"Итоговый размер вклада {s} руб.");
        }
    }
}
