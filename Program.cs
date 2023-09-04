using System;
using static System.Console;
using Tool;
using ToolNode;
using ToolLinkedList;
using Borrower;
using BorrowerNode;
using BorrowerLinkedList;

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

        public void InitialiseToolCategories()
        {
            // Gardening tools
            Tool tool1 = new Tool("pruner", "used for trimming branches, leaves and stems", 5);
            Tool tool2 = new Tool("spade", "used for breaking up soil and creating holes", 5);
            ToolLinkedList gardening = new ToolLinkedList(tool1);

            // Flooring tools
            Tool tool3 = new Tool("floor nailer", "used for attaching wooden flooring with nails", 5);
            Tool tool4 = new Tool("title cutter", "used for cutting ceramic, porcelain or stone", 5);
            ToolLinkedList flooring = new ToolLinkedList(tool3);

            // Fencing tools
            Tool tool5 = new Tool("hole digger", "used for digging holes for fence posts",5 );
            Tool tool6 = new Tool("wire cutter", "used for cutting fencing wire", 5);
            ToolLinkedList fencing = new ToolLinkedList(tool5);

            // Measuring tools
            Tool tool7 = new Tool("tape measure", "used for measuring distances, lengths, dimensions", 5);
            Tool tool8 = new Tool("spirit level", "used for checking level and alignment of surfaces", 5);
            ToolLinkedList measuring = new ToolLinkedList(tool7);

            // Cleaning tools
            Tool tool9 = new Tool("broom", "used for sweeping dirt and debris from floors", 5);
            Tool tool10 = new Tool("vacuum cleaner", "used for sucking up dirt and dust", 5);
            ToolLinkedList cleaning = new ToolLinkedList(tool9);

            // Painting tools
            Tool tool11 = new Tool("paint roller", "used for applying paint to large surfaces", 5);
            Tool tool12 = new Tool("paintbrush", "used for applying paint to small areas", 5);
            ToolLinkedList painting = new ToolLinkedList(tool11);

            // Electronic tools
            Tool tool13 = new Tool("multimeter", "used for measuring voltage, current in circuits", 5);
            Tool tool14 = new Tool("oscilloscope", "used for visualising waveform of signals", 5);
            ToolLinkedList electronic = new ToolLinkedList(tool13);

            // Electricity tools
            Tool tool15 = new Tool("wire stripper", "used for removing insulation from ends of wires", 5);
            Tool tool16 = new Tool("circuit tester", "used for determining properly functioning circuit", 5);
            ToolLinkedList electricity = new ToolLinkedList(tool15);

            // Automotive tools
            Tool tool17 = new Tool("jack stand", "used for holding up vehicle", 5);
            Tool tool18 = new Tool("oil filter wrench", "used for removing and tightening oil filter", 5);
            ToolLinkedList automotive = new ToolLinkedList(tool17);
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
            string category = ChooseCategory();
        }

        public void AddTool()
        {
            string category = ChooseCategory();
        }

        public void BorrowTool()
        {
            string category = ChooseCategory();
        }

        public void ReturnTool()
        {
            string category = ChooseCategory();
        }

    }
}
