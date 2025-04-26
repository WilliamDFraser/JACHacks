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
            char input = 'D'; //Default char
            Console.WriteLine("You have selected Avalanche Method");
            Console.WriteLine();
            Console.WriteLine("The Avalanche Method focuses on paying the debt with the highest interest rate");
            Console.WriteLine("It will then move to the next one");
            Console.WriteLine("The other payments will be made using the minimum ammount");
            Console.WriteLine("Once the smallest is gone it will tackle the next one");
            Console.WriteLine();
            Console.WriteLine("Would you like to continue with the Avalanche Method? (y/n)");
            while (!char.TryParse(Console.ReadLine(), out input) || (input != 'y' && input != 'n'))
            {
                Console.WriteLine("Please input a valid answer");
            }
        }
        static void Consolidation()
        {
            char input = 'D'; //Default char
            Console.WriteLine("You have selected Consolidation Method");
            Console.WriteLine();
            Console.WriteLine("The Consolidation Method is used to focus on paying the smallest debt");
            Console.WriteLine("The other payments will be made using the minimum ammount");
            Console.WriteLine("Once the smallest is gone it will tackle the next one");
            Console.WriteLine();
            Console.WriteLine("Would you like to continue with the Snowball Method? (y/n)");
        }
    }
}
