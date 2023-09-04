using System;
using static System.Console;
namespace ToolLibrary
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] toolCategories = new string[9] { "gardening", "flooring", "fencing", "measuring", "cleaning"
                                                 "painting", "electronic", "electricity", "automotive"};
            WriteLine("Welcome to tool management system!");
            DisplayMenu();
            ChooseOption();
        }

        public void DisplayMenu()
        {
            WriteLine("1 - Display tool details by category");
            WriteLine("2 - Add a new tool");
            WriteLine("3 - Borrow a tool");
            WriteLine("4 - Return a tool");
            WriteLine("5 - Exit");
        }

        public void ChooseOption()
        {
            Write("Enter an option number between 1 and 5 >> ");
            string optionString = ReadLine() ?? "";
            int optionNumber;
            while (!int.TryParse(optionString, out optionNumber) || optionNumber < 1 || optionNumber > 2)
            {
                Write("Invalid number! Enter an option number between 1 and 5 >> ");
                optionString = ReadLine() ?? "";
            }

            switch (optionNumber):
            {
                case 1:
                    DisplayTool();
                case 2:
                    AddTool();
                case 3:
                    BorrowTool();
                case 4:
                    ReturnTool();
                case 5:
                    return;
                default:
                    return ("Invalid option!");
            }
        }

        public string ChooseCategory()
        {
             WriteLine("Categories: ");
             for (int i = 0; i < toolCategories.Length; i++)
             {
                Write("{0}, ", toolCategories[i]);
             }

             Write("Enter category name from available list above >> ");
             int categoryString = ReadLine() ?? "";
             bool foundCategory = false;
             for (i = 0; i < toolCategories.Length; i++)
                 {
                    if (toolCategories == categoryString)
                      {
                          foundCategory = true;
                          break;
                      }
                 }
             while (!foundCategory)
             {
                Write("Invalid category! Enter available category name >> ");
                categoryString = ReadLine()??"";
                for (i = 0; i < toolCategories.Length; i++)
                {
                   if (toolCategories == categoryString)
                     {
                         foundCategory = true;
                         break;
                     }
                }
             }
             return categoryString;
        }

        public void DisplayTool()
        {
            ChooseCategory();
        }

        public void AddTool()
        {
            ChooseCategory();
        }

        public void BorrowTool()
        {
            ChooseCategory();
        }

        public void ReturnTool()
        {
            ChooseCategory();
        }

    }
}
