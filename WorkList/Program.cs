using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace WorkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new list <int>();
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           


            //action
            int PositiveCount = 0;
            int NegativeCount = 0;
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Chetnite chilsa sa -------->");
            foreach (int chervenoKvadratche in numbers)
            {
                if (chervenoKvadratche %2== 0)
                {
                    Console.WriteLine(chervenoKvadratche);
                    PositiveCount++;
                }
             
            }
            Console.WriteLine("Nechetnite chilsa sa --------->");    
            foreach (int chervenoKvadratche in numbers)
            {
                if ( chervenoKvadratche <0)
                {
                    Console.WriteLine(chervenoKvadratche);
                    NegativeCount++;
                }
                Console.WriteLine($"Broi chetni chisla ---------> {PositiveCount}");
                Console.WriteLine($"Broi nechetni chisla ---------> {NegativeCount}");

            }
             

            //output
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
