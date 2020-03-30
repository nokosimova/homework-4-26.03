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
            Console.Write("\n");
            }

            {
            Console.WriteLine("------------------ Задача 3.1 --------------------------");
            Console.WriteLine("Нарисовать прямоугольник: \n");
            int i, j;
            int weight = 5;
            int len = 20;
            for (i = 1; i <= weight; i++) {
                for (j = 1; j <= len; j++){
                    if (j == 1 || j == len || i == 1 || i == weight) {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            }
                        
            {
            Console.WriteLine("------------------ Задача 3.2 --------------------------");
            Console.WriteLine("Нарисовать прямоугольный треугольник: \n");
            int i, j;
            int h = 10;
            for (i = 1; i <=  h; i++) {
                for (j = 1; j <= i; j++){
                    Console.Write("*");
                }
                Console.Write("\n");
                }
            }

            {
            Console.WriteLine("------------------ Задача 3.3 --------------------------");
            Console.WriteLine("Нарисовать равносторонний треугольник: \n");
            int i, j;
            int h, m = 15;
            h = m / 2 + 1;
            for (i = 0; i < h; i++) {
                for (j = 1; j <= m; j++){
                    if (j == m/2+1+i || j == m/2+1-i || i == h-1){
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }                
                }
                Console.Write("\n");
            }
            }

                    {
            Console.WriteLine("------------------ Задача 3.3 --------------------------");
            Console.WriteLine("Нарисовать равносторонний треугольник: \n");
            int i, j;
            int h, m = 20;
            h = m / 2 + 1;
            for (i = 0; i < h-4; i++) {
                for (j = 1; j <= m; j++){
                    if (j == m/2+1+i || j == m/2+1-i || i == h-2){
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }                
                }
                Console.Write("\n");
            }
            for (i = h - 4; i >= 0; i--) {
                for (j = 1; j <= m; j++){
                    if (j == m/2+1+i || j == m/2+1-i || i == h-2){
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }                
                }
                Console.Write("\n");
            }
            }
            Console.ReadKey();
        }
        }
    }
