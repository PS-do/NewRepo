namespace LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sum = 1000;
            double Sum2 = Sum * 2;
            double p = 4;
            int years = 0;
            while  (Sum<Sum2)
            {
                Sum += Sum * p / 100;
                years++;
            }
            Console.WriteLine(years);
            Console.ReadKey();
        }
    }
}