using System;
using static System.Console;

namespace ToolLibrary
{
    class Program
    {

        public static void Main(string[] args)
        {
            // Initialise tool categories
            // Gardening tools
            Tool tool1 = new Tool("pruner", "used for trimming branches, leaves and stems", 5);
            Tool tool2 = new Tool("spade", "used for breaking up soil and creating holes", 5);
            ToolLinkedList gardening = new ToolLinkedList(tool1);
            gardening.InsertNewTool(tool2);

            // Flooring tools
            Tool tool3 = new Tool("floor nailer", "used for attaching wooden flooring with nails", 5);
            Tool tool4 = new Tool("title cutter", "used for cutting ceramic, porcelain or stone", 5);
            ToolLinkedList flooring = new ToolLinkedList(tool3);
            flooring.InsertNewTool(tool4);

            // Fencing tools
            Tool tool5 = new Tool("hole digger", "used for digging holes for fence posts", 5);
            Tool tool6 = new Tool("wire cutter", "used for cutting fencing wire", 5);
            ToolLinkedList fencing = new ToolLinkedList(tool5);
            fencing.InsertNewTool(tool6);

            // Measuring tools
            Tool tool7 = new Tool("tape measure", "used for measuring distances, lengths, dimensions", 5);
            Tool tool8 = new Tool("spirit level", "used for checking level and alignment of surfaces", 5);
            ToolLinkedList measuring = new ToolLinkedList(tool7);
            measuring.InsertNewTool(tool8);

            // Cleaning tools
            Tool tool9 = new Tool("broom", "used for sweeping dirt and debris from floors", 5);
            Tool tool10 = new Tool("vacuum cleaner", "used for sucking up dirt and dust", 5);
            ToolLinkedList cleaning = new ToolLinkedList(tool9);
            cleaning.InsertNewTool(tool10);

            // Painting tools
            Tool tool11 = new Tool("paint roller", "used for applying paint to large surfaces", 5);
            Tool tool12 = new Tool("paint brush", "used for applying paint to small areas", 5);
            ToolLinkedList painting = new ToolLinkedList(tool11);
            painting.InsertNewTool(tool12);

            // Electronic tools
            Tool tool13 = new Tool("multimeter", "used for measuring voltage, current in circuits", 5);
            Tool tool14 = new Tool("oscilloscope", "used for visualising waveform of signals", 5);
            ToolLinkedList electronic = new ToolLinkedList(tool13);
            electronic.InsertNewTool(tool14);

            // Electricity tools
            Tool tool15 = new Tool("wire stripper", "used for removing insulation from ends of wires", 5);
            Tool tool16 = new Tool("circuit tester", "used for determining properly functioning circuit", 5);
            ToolLinkedList electricity = new ToolLinkedList(tool15);
            electricity.InsertNewTool(tool16);

            // Automotive tools
            Tool tool17 = new Tool("jack stand", "used for holding up vehicle", 5);
            Tool tool18 = new Tool("oil filter wrench", "used for removing and tightening oil filter", 5);
            ToolLinkedList automotive = new ToolLinkedList(tool17);
            automotive.InsertNewTool(tool18);

            ToolLinkedList[] toolCategories = new ToolLinkedList[9] { gardening , flooring, fencing, measuring, cleaning,
                                                             painting, electronic, electricity, automotive};
            string[] categories = new string[9] { "gardening", "flooring", "fencing", "measuring", "cleaning",
                                                  "painting", "electronic", "electricity", "automotive"};

            Borrower borrower1 = new Borrower("Ha", "Mai", "12345678");
            BorrowerLinkedList borrowerList = new BorrowerLinkedList(borrower1);

            WriteLine("Welcome to tool management system!");
            DisplayMenu();
            int optionNumber = ChooseOption();

            while (optionNumber != 5)
            {
                int index = ChooseCategory(categories);
                switch (optionNumber)
                {
                    case 1:
                        DisplayTool(toolCategories, index);
                        WriteLine();
                        break;
                    case 2:
                        AddTool(toolCategories, index);
                        WriteLine();
                        break;
                    case 3:
                        DisplayTool(toolCategories, index);
                        BorrowTool(toolCategories, index, borrowerList);
                        WriteLine();
                        break;
                    case 4:
                        DisplayTool(toolCategories, index);
                        ReturnTool(toolCategories, index, borrowerList);
                        WriteLine();
                        break;
                    default:
                        return;
                }
                DisplayMenu();
                optionNumber = ChooseOption();
            }
        }

        // Method to display menu options
        public static void DisplayMenu()
        {
            WriteLine("1 - Display tool details by category");
            WriteLine("2 - Add a new tool");
            WriteLine("3 - Borrow a tool");
            WriteLine("4 - Return a tool");
            WriteLine("5 - Exit");
        }

        // Method for user to choose a functional option
        public static int ChooseOption()
        {
            Write("Enter a menu option number between 1 and 5 >> ");
            string optionString = ReadLine() ?? "";
            int optionNumber;
            while (!int.TryParse(optionString, out optionNumber) || optionNumber < 1 || optionNumber > 5)
            {
                Write("Invalid number! Enter an option number between 1 and 5 >> ");
                optionString = ReadLine() ?? "";
            }
            return optionNumber;
        }

        // Method for user to choose a category from available categories
        public static int ChooseCategory(string[] categories)
        {
            int index = 0;
            Write("Available categories: ");
            for (int i = 0; i < categories.Length; i++)
            {
                Write("{0}   ", categories[i]);
            }
            WriteLine();
            Write("Enter category name from available list above >> ");
            string categoryString = ReadLine() ?? "";
            bool foundCategory = false;
            for (int i = 0; i < categories.Length; i++)
                {
                if (categories[i] == categoryString)
                {
                    foundCategory = true;
                    index = i;
                    break;
                }
            }

            // Check if user input a valid category, if not, prompt user to re-enter a valid category
            while (!foundCategory)
            {
                Write("Invalid category! Enter available category name >> ");
                categoryString = ReadLine()??"";
                for (int i = 0; i < categories.Length; i++)
                {
                    if (categories[i] == categoryString)
                    {
                        foundCategory = true;
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        // Method to display tools by category
        public static void DisplayTool(ToolLinkedList[] toolCategories, int index)
        {
            toolCategories[index].DisplayTools();
        }

        // Method to add tool to library
        public static void AddTool(ToolLinkedList[] toolCategories, int index)
        {
            Write("Enter a tool name >> ");
            string userInput = ReadLine() ?? "";
            Tool newTool = new Tool(userInput);
            if (toolCategories[index].SearchTool(newTool) == null)
            {
                Write("Enter tool description >> ");
                string newToolDescription = ReadLine() ?? "";
                Write("Enter tool quantity >> ");
                string input = ReadLine() ?? "";
                int newToolQuantity;
                while (!int.TryParse(input, out newToolQuantity) || newToolQuantity < 1)
                {
                    Write("Invalid number! Enter a number greater than 0 >> ");
                    input = ReadLine() ?? "";
                }
                Tool tool = new Tool(userInput, newToolDescription, newToolQuantity);
                toolCategories[index].InsertNewTool(tool);
                WriteLine("Tool successfully added to library!");
            }
            else
            {
                WriteLine("Tool exists in the library!");
                Write("Add quantity to update >> ");
                string quantityInput = ReadLine() ?? "";
                int quantityNumber;
                while (!int.TryParse(quantityInput, out quantityNumber) || quantityNumber < 1)
                {
                    Write("Invalid number! Enter a number greater than 0 >> ");
                    quantityInput = ReadLine() ?? "";
                }
                toolCategories[index].IncreaseToolQuantity(newTool, quantityNumber);
                WriteLine("Tool quantity successfully updated!");
            }
        }

        // Method for user to borrower tool
        public static void BorrowTool(ToolLinkedList[] toolCategories, int index, BorrowerLinkedList borrowerList)
        {
            Write("Enter borrowed tool name>> ");
            string borrowedToolName = ReadLine() ?? "";
            Tool borrowedTool = new Tool(borrowedToolName);
            while (toolCategories[index].SearchTool(borrowedTool) == null)
            {
                Write("Tool does not exist in this category. Enter available tool name >> ");
                borrowedToolName = ReadLine() ?? "";
                borrowedTool = new Tool(borrowedToolName);
            }
            Write("Enter borrowed tool quantity >> ");
            string input = ReadLine() ?? "";
            int borrowedToolQuantity;
            while (!int.TryParse(input, out borrowedToolQuantity) || borrowedToolQuantity < 1
                || borrowedToolQuantity > toolCategories[index].SearchTool(borrowedTool).ATool.ToolQuantity)
            {
                Write("Invalid number! Enter a number greater than 0 and not greater than {0} >> ",
                    toolCategories[index].SearchTool(borrowedTool).ATool.ToolQuantity);
                input = ReadLine() ?? "";
            }
            toolCategories[index].SearchTool(borrowedTool).ATool.ToolQuantity -= borrowedToolQuantity;
            borrowedTool.ToolQuantity = borrowedToolQuantity;

            Write("Enter borrower first name >> ");
            string borrowerFirstName = ReadLine() ?? "";
            Write("Enter borrower last name >> ");
            string borrowerLastName = ReadLine() ?? "";
            Write("Enter borrower mobile number >> ");
            string borrowerMobile = ReadLine() ?? "";

            Borrower newBorrower = new Borrower(borrowerLastName, borrowerFirstName, borrowerMobile);

            if (borrowerList.SearchBorrower(newBorrower) == null)
            {
                borrowerList.AddNewBorrower(newBorrower);
                newBorrower.BorrowedToolsList = new ToolLinkedList(borrowedTool);
            }
            else
                borrowerList.SearchBorrower(newBorrower).ABorrower.BorrowedToolsList.InsertNewTool(borrowedTool);

            WriteLine("Tool successfully borrowed!");
        }

        // Method for user to return tool
        public static void ReturnTool(ToolLinkedList[] toolCategories, int index, BorrowerLinkedList borrowerList)
        {
            Write("Enter borrower first name >> ");
            string borrowerFirstName = ReadLine() ?? "";
            Write("Enter borrower last name >> ");
            string borrowerLastName = ReadLine() ?? "";
            Write("Enter borrower mobile number >> ");
            string borrowerMobile = ReadLine() ?? "";

            Borrower borrower = new Borrower(borrowerLastName, borrowerFirstName, borrowerMobile);

            if (borrowerList.SearchBorrower(borrower) == null)
                WriteLine("No borrower with these details in the record!");
            else
            {
                Write("Enter returned tool name >> ");
                string returnedToolName = ReadLine() ?? "";
                Write("Enter returned tool quantity >> ");
                string input = ReadLine() ?? "";
                int returnedToolQuantity;
                while (!int.TryParse(input, out returnedToolQuantity) || returnedToolQuantity < 1)
                {
                    Write("Invalid number! Enter a number greater than 0 >> ");
                    input = ReadLine() ?? "";
                }
                Tool returnedTool = new Tool(returnedToolName, " ", returnedToolQuantity);
                borrowerList.SearchBorrower(borrower).ABorrower.BorrowedToolsList.SearchTool(returnedTool).ATool.ToolQuantity -= returnedToolQuantity;
                toolCategories[index].SearchTool(returnedTool).ATool.ToolQuantity += returnedToolQuantity;
                WriteLine("Tool successfully returned! ");
                if (borrowerList.SearchBorrower(borrower).ABorrower.BorrowedToolsList.SearchTool(returnedTool).ATool.ToolQuantity == 0)
                {
                    borrowerList.SearchBorrower(borrower).ABorrower.BorrowedToolsList.RemoveTool(returnedTool);
                }
                if (borrowerList.SearchBorrower(borrower).ABorrower.BorrowedToolsList.Head == null)
                {
                    borrowerList.RemoveBorrower(borrower);
                }
            }
        }
    }
}
