using System;
using static System.Console;
namespace ToolLibrary
{
    class Program
    {
        static Dictionary<string, Tool> toolInventory = new Dictionary<string, Tool>();
        static List<Tool> rentedTools = new List<Tool>();
        static List<Borrower> borrowers = new List<Borrower>();

        static void Main(string[] args)
        {
            Write("Enter 1 if you are a staff or 2 if you are a customer >> ");
            string userInput = ReadLine() ?? "";
            int userOption;
            while (!int.TryParse(userInput, out userOption) || userOption < 1 || userOption > 2)
            {
                Write("Invalid option! Please enter either 1 or 2: ");
                userInput = ReadLine() ?? "";
            }

            //Scenario 1: Staff
            if (userOption == 1)
            {
                int staffOption = 1;
                while (staffOption != 0)
                {
                    Write("Enter 1 to add tool to inventory or 0 to quit >> ");
                    string staffInput = ReadLine() ?? "";
                    while (!int.TryParse(staffInput, out staffOption) || staffOption > 1)
                    {
                        Write("Invalid option! Please enter either 1 or 0 >> ");
                        staffInput = ReadLine() ?? "";
                    }
                    if (staffOption == 1)
                    {
                        AddToolToInventory();
                    }
                }
                
            }

            //Scenario 2: Borrower
            else
            {
                Write("Enter 1 to borrow tools, 2 to return tools or 0 to quit >> ");
                string borrowerInput = ReadLine() ?? "";
                int borrowerOption;
                while (!int.TryParse(borrowerInput, out borrowerOption) || borrowerOption > 2)
                {
                    Write("Invalid option! Please enter either 1, 2 or 0 >> ");
                    borrowerInput = ReadLine() ?? "";
                }
                if (borrowerOption == 1)
                    BorrowTools();
                else if (borrowerOption == 2)
                    ReturnTools();
                else
                    return;
            }

            
        }

        static void AddToolToInventory()
        {
            Write("Enter tool name >> ");
            string toolName = ReadLine() ?? "";

            if(toolInventory.ContainsKey(toolName))
            {
                Write("Tool has already existed. Enter number of additional tool >> ");
                int numOfTool = Convert.ToInt32(ReadLine());
                toolInventory[toolName].Quantity += numOfTool;
            }
            else
            {
                Write("Enter tool description >> ");
                string toolDescription = ReadLine() ?? "";

                Write("Enter tool quantity >> ");
                int toolQuantity = Convert.ToInt32(ReadLine());

                Tool newTool = new Tool(toolName, toolDescription, toolQuantity);

                toolInventory.Add(toolName, newTool);
                WriteLine("Tool has been added to inventory!");
            }
        }

        static void DisplayToolsByType()
        {
            
            foreach (ToolCategory category in Enum.GetValues(typeof(ToolCategory)))
            {
                WriteLine($"{(int)category + 1}: {category}");
            }

            Write("Select a tool type number from above list >> ");
            int selectedType = Convert.ToInt32(ReadLine());

            //var toolsOfType = toolInventory.Values.Where(tool => (int)GetToolCategory(tool.ToolName) == selectedType).OrderBy(Tool => Tool.Name);
            //foreach (var tool in toolsOfType)
            //{
            //    WriteLine("Name: {0}", tool.Name);
            //    WriteLine("Description: {0}", tool.Description);
            //    WriteLine("Quantity: {0}", tool.Quantity);
            //    WriteLine();
            //}
        }

        static ToolCategory GetToolCategory(string toolName)
        {
            switch (toolName.ToLower())
            {
                case "shovel":
                case "rake":
                case "pruner":
                    return ToolCategory.Gardening;
                case "hammer":
                case "saw":
                case "nailgun":
                    return ToolCategory.Flooring;
                case "wire cutter":
                case "fence plier":
                case "fence post driver":
                    return ToolCategory.Fencing;
                case "tape measure":
                case "level":
                case "caliper":
                    return ToolCategory.Measuring;
                case "broom":
                case "mop":
                case "vacuum cleaner":
                    return ToolCategory.Cleaning;
                case "paintbrush":
                case "roller":
                case "paint tray":
                    return ToolCategory.Painting;
                case "multimeter":
                case "oscilloscope":
                case "digital logic probe":
                    return ToolCategory.Electronic;
                case "wire stripper":
                case "circuit tester":
                case "voltage detector":
                    return ToolCategory.Electricity;
                case "jack stand":
                case "lug wrench":
                case "oil filter wrench":
                    return ToolCategory.Automotive;
                default:
                    return ToolCategory.Gardening;
            }
        }
        static void BorrowTools()
        {
            DisplayToolsByType();
            WriteLine("Enter name of tool that you want to borrow >> ");
            WriteLine("Enter quantity that you want to borrow >> ");

        }

        static void ReturnTools()
        {
            WriteLine("Enter name of tool that you want to return >> ");
            WriteLine("Enter quantity that you want to return >> ");
        }
    }
}
