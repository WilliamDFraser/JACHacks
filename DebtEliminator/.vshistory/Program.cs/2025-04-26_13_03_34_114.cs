namespace DebtEliminator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DebtEliminator");
            Snowball();
        }
        static void Snowball()
        {
            char input = 'D';
            Console.WriteLine("Would you like to learn about the Snowball Method? (y/n)");
            while (!char.TryParse(Console.ReadLine(), out input) || (input != 'y' && input != 'n'))
            {
                Console.WriteLine("Please input a valid answer");
            }
        }
        static void Avalanche()
        {
            Console.WriteLine("Would you like to learn about Avalanche Method");
        }
        static void Consolidation()
        {
            Console.WriteLine("Would you like to learn about debt consolidation");
        }
    }
}
