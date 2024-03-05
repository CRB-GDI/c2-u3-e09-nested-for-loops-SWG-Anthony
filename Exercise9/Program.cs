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
            for (int i = 1; i < rows; i++)
            {
                //inner for loop printing in width
                for(int j = 1; j < rows; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}