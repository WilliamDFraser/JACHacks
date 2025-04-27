using System.Globalization;

namespace DebtEliminator
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<DebtType> List_Of_Debts = new List<DebtType>();
            char input;
            byte methodSelector = 0;

            //bool Add_More_Debts = true;
            //int Debt_Count = 0;

            //char input = 'D'; //Default char
            //int i = 0;
            //string name;
            //decimal ammount;
            //decimal interest = 0;
            //decimal minimumPayment = 0;
            //int i = 0;
            //decimal amount;
            //string name;
            //byte methodSelector=0;

            //Print_Centered_Title("Debt Eliminator", '*', 3);
            //Console.WriteLine("\n\n\n");

            //while (Add_More_Debts)
            //{
            //    Debt_Count++;


            //    name = Print_Input_Box("Name of debt:");

            //    while (!decimal.TryParse(Print_Input_Box("Amount left to pay:", Min_Width: 40), out amount) || amount <= 0)
            //    {
            //        Console.WriteLine("Invalid input! Please enter a positive number.");
            //    }

            //    List_Of_Debts.Add(new DebtType(name, amount, interest, minimumPayment));

            //    char Choice;
            //    do
            //    {
            //        string Answer = Print_Input_Box("Add another debt ? (Y / N)", Min_Width: 20);
            //        Choice = char.ToUpper(Answer[0]);

            //    } while (Choice != 'Y' && Choice != 'N');
            //    Add_More_Debts = (Choice == 'Y');
            //}
            //  Print_Summary(List_Of_Debts);

            do
            {
                Console.Clear();
                Print_Centered_Title("Debt Eliminator", '*', 3);
                Console.WriteLine("\n\n\n");

                string name;
                decimal amount, interest, minimumPayment;

                //Print_Context_Text($"Please enter the data for debt {i}");

                //Print_Input_Box("Name of debt:");
                //name = Console.ReadLine();

                name = Get_Valid_Input("Name of debt : ", Validate: s => !string.IsNullOrWhiteSpace(s), ErrorMsg: "Name cannot be empty");

                amount = Get_Valid_Decimal_Input("Amount left to pay : ", Min_Value: 0.01m, ErrorMsg: "Please enter a positive amount");

                interest = Get_Valid_Decimal_Input("Monthly interest rate (%) : ", Min_Value: 0, ErrorMsg: "Interest rate cannot be negative");

                minimumPayment = Get_Valid_Decimal_Input("Minimum Monthly Payment : ", Min_Value: 0.01m, ErrorMsg: "Payment must be positive");


                //Print_Input_Box("Amount left to pay:", Min_Width: 40);
                //while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                //{               
                //    Print_Input_Box("Invalid input! Please enter a positive number.");            
                //    Console.Write("Invalid input! Please enter a positive number.");
                //}
                
                //Print_Input_Box("Monthly interest rate:");       
                //Print_Input_Box("interest rate:");

                //while (!decimal.TryParse(Console.ReadLine(), out interest) || interest < 0
                //{             
                //    Print_Input_Box("Please input a valid answer");                
                //    Print_Context_Text("Please input a valid answer");
                //}
                //Print_Input_Box("Minimum Monthly Payment:");

                //while (!decimal.TryParse(Console.ReadLine(), out minimumPayment) || minimumPayment <= 0)
                //{                 
                //    Print_Input_Box("Please input a valid answer");           
                //    Print_Context_Text("Please input a valid answer");
                //}

                //Call debt type constructor
                //DebtType debt = new DebtType(name, amount, interest, minimumPayment);
                List_Of_Debts.Add(new DebtType(name, amount, interest, minimumPayment));

                input = Get_Valid_Choice("Add another debt ? (Y / N) ", ValidChoices: new[] { 'Y', 'N' });

                //Print_Input_Box("Would you like to add another debt? (y/n)");

                //while (!char.TryParse(Console.ReadLine().ToUpper(), out input) || (input != 'Y' && input != 'N'))//fixed to upper
                //{
                //    Print_Context_Text("Please input a valid answer");
                //}

            } while (input == 'Y');

            while (methodSelector != 4)
            {
                Console.Clear();
                Print_Centered_Title("Debt Eliminator", '*', 3);
                Console.WriteLine("\n\n\n");

                Print_Context_Box("Please select one from below : ", '-');
                Print_Context_Text("1.Snowball Method");
                Print_Context_Text("2.Avalanche Method");
                Print_Context_Text("3.Debt Consolidation");
                Print_Context_Text("4. Exit");
                Print_Bottom_Border('-');

                methodSelector = Get_Valid_Byte_Input("Select option ( 1 - 4 ) : ", MinValue: 1, MaxValue: 4, ErrorMsg: "Please enter a number between 1 - 4");

                switch (methodSelector)
                {
                    case 1:
                        Snowball(List_Of_Debts);
                        break;
                    case 2:
                        Avalanche(List_Of_Debts);
                        break;
                    case 3:
                        Consolidation(List_Of_Debts);
                        break;
                }

                //while (!byte.TryParse(Console.ReadLine(), out methodSelector) || methodSelector > 4)
                //{
                //    Print_Input_Box("Please select a valid option");
                //}
                //if (methodSelector == 1)
                //{
                //    Snowball();
                //}
                //else if (methodSelector == 2)
                //{
                //    Avalanche();
                //}
                //else if (methodSelector == 3)
                //{
                //    Consolidation();
                //}
            }
            //Console.Clear();
            //Print_Centered_Title("Debt Eliminator", '*', 3);
            //Console.WriteLine("\n\n\n");
            //Print_Context_Box("Please select one from below : ", '-');
            //Print_Context_Text("1.Snowball Method");
            //Print_Context_Text("2.Avalanche Method");
            //Print_Context_Text("3.Debt Consolidation");


            //    Print_Bottom_Border('-');
            //Print_Context_Text("\n\n\n");

            //Print_Context_Box("Results : ", '=');
            //Print_Context_Text("Here's the context of output : ");
            //Print_Bottom_Border('=');
        }

        static string Get_Valid_Input(string Prompt, Func<string, bool> Validate, string ErrorMsg)
        {
            string Input;
            do
            {
                Print_Centered_Title("Debt Eliminator", '*', 3);
                Console.WriteLine("\n\n\n");
                Print_Input_Box(Prompt);
                Input = Console.ReadLine();
                if (!Validate(Input))
                {
                    Print_Context_Text(ErrorMsg, '!');
                    Console.ReadKey();
                }
            } while (!Validate(Input));

            return Input;
        }

        static decimal Get_Valid_Decimal_Input(string Prompt, decimal Min_Value, string ErrorMsg)
        {
            decimal Value;
            do
            {
                Print_Centered_Title("Debt Eliminator", '*', 3);
                Console.WriteLine("\n\n\n");
                Print_Input_Box(Prompt);
                if (!decimal.TryParse(Console.ReadLine(), out Value) || Value < Min_Value)
                {
                    Print_Context_Text(ErrorMsg, '!');
                    Console.ReadKey();
                }
            } while (Value < Min_Value);

            return Value;
        }

        static char Get_Valid_Choice(string Prompt, char[] ValidChoices)
        {
            char choice;
            do
            {
                Print_Centered_Title("Debt Eliminator", '*', 3);
                Console.WriteLine("\n\n\n");
                Print_Input_Box(Prompt);
                if (!char.TryParse(Console.ReadLine().ToUpper(), out choice))
                {
                    Print_Context_Text("Invalid input !", '!');
                    Console.ReadKey();
                }
            } while (!ValidChoices.Contains(choice));

            return choice;
        }

        static byte Get_Valid_Byte_Input(string Prompt, byte MinValue, byte MaxValue, string ErrorMsg)
        {
            byte Value;
            do
            {
                Console.Clear();
                Print_Centered_Title("Debt Eliminator", '*', 3);
                Console.WriteLine("\n\n\n");
                Print_Input_Box(Prompt);
                if (!byte.TryParse(Console.ReadLine(), out Value) || Value < MinValue || Value > MaxValue)
                {
                    Print_Context_Text(ErrorMsg, '!');
                    Console.ReadKey();
                }
            } while (Value < MinValue || Value > MaxValue);

            return Value;
        }

        static void Print_Debt_Summary(List<DebtType> debts)
        {
            Console.Clear();
            Print_Centered_Title("Debt Eliminator", '*', 3);
            Console.WriteLine("\n\n\n");

            foreach (var debt in debts)
            {
                Print_Context_Text($"{debt.Type}: {debt.DebtAmount:C2} at {debt.IntrestRate}% interest");
            }
            Print_Input_Box("Press any key to continue ...");
            Console.ReadKey();
        }
        
        static int Get_Console_Width()
        {
            return Console.WindowWidth - 1;
        }

        static void Print_Input_Box(string Prompt, int Min_Width = 30, char Border_Char = '-')
        {
            int ConsoleWidth = Console.WindowWidth;
            int Box_Width = Math.Max(Prompt.Length + 6, Min_Width);
            int Left_Padding = (ConsoleWidth - Box_Width) / 2;

            Console.WriteLine(new string(' ', Left_Padding) + new string(Border_Char, Box_Width));
            string Padding_Prompt = Prompt.PadRight(Box_Width - 4);
            Console.WriteLine(new string(' ', Left_Padding) + $"| {Padding_Prompt}");

            Console.Write(new string(' ', Left_Padding) + "| ");
            int CursoLeft = Console.CursorLeft;
            int CursoTop = Console.CursorTop;
            Console.Write(new string(' ', Box_Width - 4));
            Console.WriteLine(" |");

            Console.WriteLine(new string(' ', Left_Padding) + new string(Border_Char, Box_Width));

            Console.SetCursorPosition(CursoLeft, CursoTop);

        }

        //static void SetCurcorPoition(int postions)
        //{
        //    Console.SetCursorPosition((Console.WindowWidth / 2) - 1, (Console.WindowHeight / 2) + postions);
        //}

        static void Print_Context_Text(string Text, char PaddingChar = ' ')
        {
            int ConsoleWidth = Get_Console_Width();
            int Padding = (ConsoleWidth - Text.Length) / 2;

            if (Padding < 0) Padding = 0;
            if (Text.Length > ConsoleWidth) Text = Text.Substring(0, ConsoleWidth);

            Console.WriteLine(Text.PadLeft(Padding + Text.Length, PaddingChar));
        }

        static void Print_Bottom_Border(char BorderChar)
        {
            Print_Context_Text(new string(BorderChar, Get_Console_Width()));
        }

        static void Print_Centered_Title(string Title, char Board_Char, int Box_Padding = 1)
        {
            int ConsoleWidth = Get_Console_Width();
            int Box_Width = Math.Min(Title.Length + (Box_Padding * 2) + 2, ConsoleWidth - 2);

            Print_Context_Text(new string(Board_Char, Box_Width));

            string Padding_Title = Title.PadLeft(Title.Length + Box_Padding).PadRight(Title.Length + (Box_Padding * 2));
            Print_Context_Text(Board_Char + Padding_Title + Board_Char);

            Print_Context_Text(new string(Board_Char, Box_Width));

            //Console.WriteLine(new string(Board_Char, Width));

            //int Padding = (Width - Title.Length - 2) / 2;
            //string Padding_Title = new string(' ', Padding) + Title + new string(' ', Padding);

            //if ((Width - Title.Length - 2) % 2 != 0)
            //{
            //    Padding_Title += " ";
            //}

            //    Console.WriteLine(Board_Char + Padding_Title + Board_Char);
            //    Console.WriteLine(new string(Board_Char, Width));
            //}
        }

        static void Print_Context_Box(string Header, char Board_Char)
        {
            int ConsoleWidth = Get_Console_Width();
            int BoxWidth = Math.Min(Header.Length + 4, ConsoleWidth - 2);

            Print_Context_Text(new string(Board_Char, BoxWidth));
            string PaddingHeader = " " + Header + " ";

            PaddingHeader = PaddingHeader.PadRight(BoxWidth - 2);
            Print_Context_Text(Board_Char + PaddingHeader + Board_Char);

            Print_Context_Text(new string(Board_Char, BoxWidth));

            //Console.WriteLine(new string('-', Width));
            //Console.WriteLine("| " + Header.PadRight(Width - 4) + " |");
            //Console.WriteLine(new string('-', Width));
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
            while (!char.TryParse(Console.ReadLine().ToUpper(), out input) || (input != 'Y' && input != 'N'))
            {
                Console.WriteLine("Please input a valid answer");
            }
            if (input == 'N')
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
            while (!char.TryParse(Console.ReadLine().ToUpper(), out input) || (input != 'Y' && input != 'N'))
            {
                Console.WriteLine("Please input a valid answer");
            }
            if (input == 'N')
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
            while (!char.TryParse(Console.ReadLine().ToUpper(), out input) || (input != 'Y' && input != 'N'))
            {
                Console.WriteLine("Please input a valid answer");
            }
            if (input == 'N')
                return;
            else
            {

            }
        }

    }
}