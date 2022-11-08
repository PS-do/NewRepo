namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine("Квадрат числа {0} равен {1}", i, i * i);
            }
            Console.ReadKey();
        }
    }
}