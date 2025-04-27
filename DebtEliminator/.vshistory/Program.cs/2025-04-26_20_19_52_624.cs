namespace DebtEliminator
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<DebtType> List_Of_Debts = new List<DebtType>();
            bool Add_More_Debts = true;
            int Debt_Count = 0;

            char input = 'D'; //Default char
            //int i = 0;
            //string name;
            //decimal ammount;
            decimal interest=0;
            decimal minimumPayment=0;
            int i=0;
            decimal amount;
            string name;
            Print_Centered_Title("Debt Eliminator", '*', 3);
            Console.WriteLine("\n\n\n");

            while (Add_More_Debts)
            {
                Debt_Count++;
                Console.Clear();

                name = Print_Input_Box("Name of debt:");
                
                while (!decimal.TryParse(Print_Input_Box("Amount left to pay:", Min_Width: 40), out amount) || amount <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a positive number.");
                }

                List_Of_Debts.Add(new DebtType(name, amount, interest, minimumPayment));

                char Choice;
                do
                {
                    string Answer = Print_Input_Box("Add another debt ? (Y / N)", Min_Width: 20);
                    Choice = char.ToUpper(Answer[0]);

                } while (Choice != 'Y' && Choice != 'N');
                Add_More_Debts = (Choice == 'Y');
            }
          //  Print_Summary(List_Of_Debts);

            do
            {


                i++;
                int postions = -6;
                Print_Context_Text($"Please enter the data for debt {i}");

                Print_Context_Text("Name of debt:");
                SetCurcorPoition(postions);
                name = Console.ReadLine();
                Print_Context_Text("Ammount left to pay:");
                postions += 2;
                SetCurcorPoition(postions);
                while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                {
                    postions += 2;
                    Print_Context_Text("Please input a valid answer");
                    SetCurcorPoition(postions);
                }
                postions += 2;
                Print_Context_Text("interest rate:");
                SetCurcorPoition(postions);
                while (!decimal.TryParse(Console.ReadLine(), out interest) || interest < 0)

                {

                    postions += 2;

                    Print_Context_Text("Please input a valid answer");
                    SetCurcorPoition(postions);
                }
                postions += 2;
                Print_Context_Text("Minimum Monthly Payment:");
                SetCurcorPoition(postions);
                while (!decimal.TryParse(Console.ReadLine(), out minimumPayment) || minimumPayment <= 0)
                {
                    postions += 2;
                    Print_Context_Text("Please input a valid answer");
                    SetCurcorPoition(postions);
                }
                postions += 2;
                //Call debt type constructor

                Print_Context_Text("Would you like to add another debt? (y/n)");
                SetCurcorPoition(postions);
                while (!char.TryParse(Console.ReadLine().ToUpper(), out input) || (input != 'Y' && input != 'N'))//fixed to upper

                {
                    postions += 2;
                    Print_Context_Text("Please input a valid answer");
                    SetCurcorPoition(postions);
                }

            } while (input == 'Y');

            Print_Context_Box("Please select one from below : ", '-');
            Print_Context_Text("1.___");
            Print_Context_Text("2.___");
            Print_Context_Text("3.___");


            Print_Bottom_Border('-');
            Print_Context_Text("\n\n\n");

            Print_Context_Box("Results : ", '=');
            Print_Context_Text("Here's the context of output : ");
            Print_Bottom_Border('=');

            // int padding = (consoleWidth - text.Length) / 2;
            // Console.WriteLine(text.PadLeft(padding + text.Length)); int padding = (consoleWidth - text.Length) / 2;
            // Console.WriteLine(text.PadLeft(padding + text.Length));
        }

        static int Get_Console_Width()
        {
            return Console.WindowWidth - 1;
        }

        static string Print_Input_Box(string Prompt, int Min_Width = 30, char Border_Char = '-')
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
            return Console.ReadLine();
        }

        static void SetCurcorPoition(int postions)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - 1, (Console.WindowHeight / 2) + postions);
        }
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

        //static void Print_OutPut_Box(string Header, int Width)
        //{
        //    Console.WriteLine(new string('=', Width));
        //    Console.WriteLine("|| " + Header.PadRight(Width - 5) + " ||");
        //    Console.WriteLine(new string('=', Width));
        //}

        static void Print_Summary(List<DebtType> List_Of_Debts)
        {
            Console.Clear();
            Print_Centered_Title("Debt Summary", '*', 3);

            foreach (var debt in List_Of_Debts)
            {
                Console.WriteLine($"• {debt.name}: {debt.DebtAmount:C2}(Interest : {debt.Interest}%)");
            }

            Print_Input_Box("Press any key to continue...", Min_Width: 30);
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