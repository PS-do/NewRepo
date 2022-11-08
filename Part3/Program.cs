﻿namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть №3\n" +
                "Задачи на использование операторов цикла с предусловием. \n" +
                "Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла while,\n" +
                " обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.\n" +
                "Задачи\n\n" +
                "1/ Ввести положительные числа A, B, C.\n" +
                " На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).\n" +
                " Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.");
            double A, B, C;
            Console.WriteLine("Введите сторону прямоугольника А: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону вписываемых квадратов С: ");
            C = Convert.ToDouble(Console.ReadLine());

            int N_Square = 0;
            double L_A, L_B; //ntreofz dtkbxbyf pfvjotybz rdflhfnfvb d ljkm cjjndtncnde.otq cnjhjys
            int n_A, n_B;
            n_A = n_B = 0; //Кол-во квадратов вдоль соответствующей стороны

            L_A = 0;
            while (L_A<A)
            {
                L_B = 0;
                while (L_B<B)
                {
                    L_B += C;
                    if (L_B <= B) N_Square++;
                }
                L_A += C;
            }
            Console.WriteLine("Количество вписаных в прямоугольник квадратов составляет:{0}",N_Square);
            Console.ReadKey();

        }
    }
}