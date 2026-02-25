namespace PregovorNaSpusuci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad da se vuvede Spisuk number
            //chisla
            List<int>  numbers  = new List<int>();

            //imena 
            List<string> imena = Console.ReadLine().Split().ToList();

            //da gi vkarame edno po edno s ( .Add ) ot klaviaturata
            int imput = int.Parse(Console.ReadLine());
            while (imput != 0)
            {
                numbers.Add( imput );
                imput = int.Parse(Console.ReadLine());
            }

            // Otpechatvane
            
          //  Console.WriteLine(string.Join (" ,");
            
               //da se prebroi broq povtoreniq



               
            
            

        }
    }
}
