namespace Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvejdane i tursene ");
            List<string> imena = new List<string>();
            imena.Add("Diyana");
            imena.Add("10");
            imena.Add("Adriana");
            Console.WriteLine("Vuvedete 3 imena: ");
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            Console.WriteLine("Vuvedete imena dokuto END zA krai : ");
            string stringInput = Console.ReadLine();  
            
            while (stringInput !="END")
            {
              imena.Add(stringInput);
                stringInput = Console.ReadLine();

            }
            if (imena.Contains("Diyana"))
            {
                Console.WriteLine("Diyana e v spisuka");
            }

            else 
            {
                Console.WriteLine("Diyana ne e v spisuka");
            }

              Console.WriteLine(string.Join(", ", imena));


        }
    }
}
