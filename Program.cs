using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            Console.WriteLine("------------------ Задача 2.1 --------------------------");
            Console.WriteLine("Даны 2 числа A и B (A>B). Выведите сумму чисел расположенных между ними");
            int A, B, i;
            int summ = 0;
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());
            for (i = A+1; i < B; i++) {
                summ += i;
            }
            Console.WriteLine($"result = {summ}");
            }
            {
                        
            Console.WriteLine("------------------ Задача 2.2 --------------------------");
            Console.WriteLine("Даны 2 числа A и B(A>B). Выведите все нечетные числа расположенных между ними");
            int A, B, i;
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine($"Нечетные числа от {A} до {B}");
            for (i = A+1; i < B; i++) {
                if (i % 2 == 1) {
                    Console.Write($"{i} ");
                }    
            }

            }
        }
    }
}
