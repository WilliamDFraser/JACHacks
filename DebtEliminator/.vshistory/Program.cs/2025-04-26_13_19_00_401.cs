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
            char input = 'D'; //Default char
            Console.WriteLine("You have selected Snowball Method");
            Console.WriteLine();
            Console.WriteLine("The Snowball Method is used to focus on paying the smallest debt");
            Console.WriteLine("The other payments will be made using the minimum ammount");
            Console.WriteLine("Once the smallest is gone it will tackle the next one");
            Console.WriteLine();
            Console.WriteLine("Would you like to continue with the Snowball Method? (y/n)");
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
