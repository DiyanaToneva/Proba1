using System.Globalization;

namespace Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Da se vivedat chisla v spisuk
            //da se vuvede vtoro chislo i da bude iztrito vseki put pri vuvejdane 

            List<int> chislo =new List<int>();

            Console.WriteLine("Vuvedete chisla : ");

            int chisla=int.Parse(Console.ReadLine());
            while (chisla!=0)
            {
                
                int numbers = int.Parse(Console.ReadLine());
                Console.Write(" sledvashto chislo:");
                numbers=int.Parse(Console.ReadLine());
                
            }
            Console.Write("Vuvedete chislo za iztrivane: ");
            int numberToRemove = int.Parse(Console.ReadLine());

            while (chisla.Contains(numberToRemove)!=-1)
            {
                chislo.Remove(chisla.IndexOf(chisla.ToRemove));
            }



            Console.WriteLine(string.Join(" ", chisla));
            











        }
    }
}
