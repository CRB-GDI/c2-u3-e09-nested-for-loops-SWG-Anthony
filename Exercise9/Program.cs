 namespace Exercise9
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a row width: ");
            int width =Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many numbers of rows? ");
            int rows =Int32.Parse(Console.ReadLine());

            //print rows
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                //inner for loop printing in width
                for(int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the max number of asterisks in a row");
            int maxasterisks = Int32.Parse(Console.ReadLine());
                

            for (int f = 0; f <= maxasterisks; f++)
            {
                //inner for loop printing in width
                for (int t = 0; t <= f; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}