namespace DebtEliminator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DebtEliminator");
        }
        static void Snowball()
        {
            char input = '';
            Console.WriteLine("Would you like to learn about the Snowball Method?");
            while (input != 'Y' || input != 'N')
            {
                input = Console.ReadLine()!;
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
