namespace Обязательная_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обязательная задача*. Ввести целое число N > 0.\n" +
                " Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1).\n" +
                " После добавления к сумме каждого слагаемого выводить текущее значение суммы \n" +
                "(в результате будут выведены квадраты всех целых чисел от 1 до N).\n");
            Console.WriteLine("Введите целое число N>0:");
            int N= Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            int n = 1;
            int i = 1;
            for (n = 1; n <= (2*N-1);)
            {
                Sum+=n;
                Console.WriteLine("n={0};    n^2={1}",i,Sum);
                n += 2;
                i++;
            }
            Console.ReadKey();
        }
    }
}