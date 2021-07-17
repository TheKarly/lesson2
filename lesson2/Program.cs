using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной a: ");
            int a = int.Parse(Console.ReadLine());
            if (b > a)
                Console.WriteLine("Ошибка! Переменная b > a");
            int i, sum = 0;
            for (i = b; a >= i; i++)
                sum += i;
            Console.WriteLine("Сумма чисел равна: " + sum);
            Console.ReadLine();

        }
    }
}
