namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maja suurus");
            int h = Convert.ToInt16(Console.ReadLine());
            
            int tri = h - 3;
            for (int i = 0; i <= tri; i++)
            {
                for (int j = 1; j <= tri - i; j++)
                    Console.Write(" ");  // Printing spaces before the asterisks

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  // Printing asterisks to form the upper part of the diamond

                Console.Write("\n");  // Moving to the next line after each row
            }
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
