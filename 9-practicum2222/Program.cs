using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_practicum2222
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеются ли в одномерном массиве случайных чисел элементы,
            //значения которых кратны 11. Вывести такие значения.

            //Random rnd = new Random();
            //const int n = 5;
            //int[] ints = new int[n];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(10, 100);
            //    Console.WriteLine($"ints[{i}]={ints[i]}");
            //}
            //Console.WriteLine("Элементы, кратные 11:");
            //foreach (var element in ints)
            //{
            //    if (element % 11 == 0)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}
            //Array.Resize(ref ints, 4);
            //Console.WriteLine($"array size= {ints.Length}");
            //foreach (var element in ints)
            //{
            //    Console.WriteLine(element);
            //}

            //Array.Resize(ref ints, 14);
            //Console.WriteLine($"array size= {ints.Length}");
            //foreach (var element in ints)
            //{
            //    Console.WriteLine(element);
            //}


            //Задача 2. Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            //int[] omas = { 4, 8, -7, 9, -31, 2, -1 };
            //int sum = 0;
            //int count = 0;
            //foreach (var x in omas)
            //{
            //    if (x > 0)
            //    {
            //        count++;
            //        sum += x;
            //    }
            //}

            //Console.WriteLine($"Количество положительных элементов в массиве: {count}\nИх сумма: {sum}");
            //Array.Clear(omas,2, 2);
            //foreach (var el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Задача 3. Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.

            //int[] gg = new int[5];
            //for (int i = 0; i < gg.Length; i++)
            //{
            //    Console.Write($"gg[{i}]= ");
            //    gg[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //1 method
            //for (int j = gg.Length; j>=0; j--) 
            //{
            //    Console.WriteLine(j);
            //}
            //2 метод
            //Array.Reverse(gg);
            //foreach (var el in gg)
            //{
            //    Console.WriteLine(el);
            //}


            //3 ЗАДАЧА 10 ПРАКТИКУМА Найти индекс первого отрицательного элемента одномерного массива,
            //заполненного случайным образом в диапазоне от -5 до 5.
            Random rnd = new Random();
            int[] massiv = new int[5];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rnd.Next(-100, 100);
                Console.WriteLine($"ints[{i}]={massiv[i]}");
            }
            for (int j = 0; j<massiv.Length; j++)
            {
                if (massiv[j] < 0)
                {
                    Console.WriteLine(massiv[j]);
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
