namespace RezultataOtTestove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi rezultatite ot 0-100");
            int[]results = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxResult = 0;
            int minResult = 100;
            int sum = 0;
             for(int i = 0; i < results.Length; i++)
             {
                if (results[i] > maxResult)
                {
                    maxResult = results[i];
                }
                if (results[i] < minResult)
                {
                    minResult = results[i];
                }
                sum += results[i];
             }
             double avg = (double)sum / results.Length;
            int  nadAvgCount = 0;
             for(int i = 0; i < results.Length; i++)
             {
                if (results[i] >= avg)
                {
                    nadAvgCount++;
                }
             }
             Console.WriteLine($"Max result is {maxResult}");
             Console.WriteLine($"Min result is {minResult}");
             Console.WriteLine($"Average result is {avg:f2}");
             Console.WriteLine($"{nadAvgCount} students have above or equal to average result");
            Console.WriteLine(string.Join(" ;" , results)); 













        }
    }
}
