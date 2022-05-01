using System;
namespace LineComparison
{
    public class UC1
    {
        public static void Usca1(int x1, int y1, int x2, int y2)
        {
            double result, sum;
            sum = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            result = Math.Sqrt(sum);
            Console.WriteLine("The length is :" + result);
            Console.ReadLine();

        }


    }
}
