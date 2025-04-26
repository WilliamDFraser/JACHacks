using System.Xml.Serialization;

namespace DebtEliminator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = 'D'; //Default char
            int i = 0;
            string name;
            decimal ammount;
            decimal interest;
            decimal minimumPayment;
            Print_Centered_Title("Debt Eliminator", '*', 60);
            Console.WriteLine("\n\n\n");

            do
            {
                Console.WriteLine($"Please enter the data for debt {i + 1}");
                Console.Write("Name of debt:");
                name = Console.ReadLine()!;
                Console.Write("Ammount left to pay:");
                while (!decimal.TryParse(Console.ReadLine(), out ammount) || ammount <= 0)
                {
                    Console.WriteLine("Please input a valid answer");
                }
                Console.Write("interest rate:");
                while (!decimal.TryParse(Console.ReadLine(), out interest) || interest < 0)
                {
                    Console.WriteLine("Please input a valid answer");
                }
                Console.Write("Minimum Monthly Payment:");
                while (!decimal.TryParse(Console.ReadLine(), out minimumPayment) || minimumPayment <= 0)
                {
                    Console.WriteLine("Please input a valid answer");
                }
                DebtType debt = new DebtType(name, );
                Console.WriteLine("Would you like to add another debt? (y/n)");
                while (!char.TryParse(Console.ReadLine(), out input) || (input != 'y' && input != 'n'))
                {
                    Console.WriteLine("Please input a valid answer");
                }

            } while (input == 'y');

            Print_Context_Box("Please select one from below : ", 60);
            Console.WriteLine("1.___");
            Console.WriteLine("2.___");
            Console.WriteLine("3.___");


            Print_Bottom_Border(60);
            Console.WriteLine("\n\n\n");

            Print_OutPut_Box("Results : ", 60);
            Console.WriteLine("Here's the context of output : ");
            Print_Bottom_Border(60);


            Snowball();
        }
        static void Print_Centered_Title(string Title, char Board_Char, int Width)
        {
            Console.WriteLine(new string(Board_Char, Width));

            int Padding = (Width - Title.Length - 2) / 2;
            string Padding_Title = new string(' ', Padding) + Title + new string(' ', Padding);

            if ((Width - Title.Length - 2) % 2 != 0)
            {
                Padding_Title += " ";
            }

            Console.WriteLine(Board_Char + Padding_Title + Board_Char);
            Console.WriteLine(new string(Board_Char, Width));
        }

        static void Print_Context_Box(string Header, int Width)
        {
            Console.WriteLine(new string('-', Width));
            Console.WriteLine("| " + Header.PadRight(Width - 4) + " |");
            Console.WriteLine(new string('-', Width));
        }

        static void Print_OutPut_Box(string Header, int Width)
        {
            Console.WriteLine(new string('=', Width));
            Console.WriteLine("|| " + Header.PadRight(Width - 5) + " ||");
            Console.WriteLine(new string('=', Width));
        }

        static void Print_Bottom_Border(int Width)
        {
            Console.WriteLine(new string('-', Width));
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
            if (input == 'n')
                return;
            else
            {

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
            if (input == 'n')
                return;
            else
            {

            }
        }
        static void Consolidation()
        {
            char input = 'D'; //Default char
            Console.WriteLine("You have selected Consolidation Method");
            Console.WriteLine();
            Console.WriteLine("The Consolidation Method transferring all debts into one big loan");
            Console.WriteLine("Usually with a lower interest rate");
            Console.WriteLine();
            Console.WriteLine("Would you like to continue with the Consolidation Method? (y/n)");
            while (!char.TryParse(Console.ReadLine(), out input) || (input != 'y' && input != 'n'))
            {
                Console.WriteLine("Please input a valid answer");
            }
            if (input == 'n')
                return;
            else
            {

            }
        }
    }
}
