namespace PregovorMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. deklarirane nasiv ot 5 int
            int[] numbers = new int[5];


            // 2.deklarirane na imena 13 dushi
            string[] imena = new string[13];


            // 3. na edin red 
            int[] arr2 = Console.ReadLine().Split(" ,").Select(int.Parse).ToArray();


            // 4.vuvejdane imena s cikul 
            for (int i  = 0;i< imena .Length;i++ )
            {
                imena[i]= Console.ReadLine();   

            }
            // 5.otpechatvane 

            //  Console.WriteLine(string .Join(",",arr2));

            // foreach
            // Console.WriteLine(i);


            //for 
           // Console.WriteLine(imena[i]);

        }
    }
}
