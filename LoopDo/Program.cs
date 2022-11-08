namespace LoopDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sum = 1000;
            double Sum2 = Sum * 2;
            double p = 4;
            int years = 0;
            do
            {
                Sum += Sum * p / 100;
                years++;
            } while (Sum < Sum2);
            Console.WriteLine(years);
            Console.ReadKey();
        }
    }
}