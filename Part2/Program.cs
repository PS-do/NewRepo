namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть №2\n" +
                "Задачи на использование операторов цикла с постусловием." +
                "Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием\n" +
                " операторов цикла do - while, обеспечить вывод полученных результатов.\n" +
                " Использование других операторов цикла недопустимо.\n\n" +
                "   Задачи\n" +
                "1. Осуществить ввод последовательности целых чисел и сравнить, что больше, количество\n" +
                " положительных или количество отрицательных. Последовательность потенциально не ограничена,\n" +
                " окончанием последовательности служит число 0.\n");
            Console.WriteLine("Введите первое число:");
            int Number = Convert.ToInt32(Console.ReadLine());
            int N_positive, N_negative;
            N_negative=N_positive=0;
            do
            {
                if (Number > 0) N_positive++;
                if (Number < 0) N_negative++;
                // if (Number == 0)break;
                Console.WriteLine("Введите следующее число:");
                Number = Convert.ToInt32(Console.ReadLine());
            } while(Number != 0);
            if (N_negative > N_positive) Console.WriteLine("Отрицательных больше");
            else if (N_negative < N_positive) Console.WriteLine("Положительных больше");
            else if (N_negative == N_positive) Console.WriteLine("Количество Положительных равно количеству отрицательных");
            Console.ReadKey();
        }
    }
}