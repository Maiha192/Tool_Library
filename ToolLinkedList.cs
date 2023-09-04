using System;
using System.Reflection;
using static System.Console;

namespace ToolLibrary
{
	public class ToolLinkedList
    {
    	private ToolNode head;
    	private ToolNode tail;
    	private int length = 0;

        public ToolNode Head
        {
            get { return head; }
        }

        public ToolNode Tail
        {
            get { return tail; }
        }

        public int Length
        {
            get { return length; }
        }
        // Initialise a linked list of tool by adding the first tool
        public ToolLinkedList(Tool tool)
    	{
    	    ToolNode newTool = new ToolNode(tool);
    	    head = newTool;
    	    tail = newTool;
    	    length = 1;
    	}

        // Method to search tool
        public ToolNode SearchTool(Tool tool)
        {
            ToolNode current = Head;
            while (current != null)
            {
                if (tool.Equals(current.ATool))
                {
                    return current; // Found the tool, so return the ToolNode
                }
                current = current.NextTool;
            }
            return null; // Tool not found, return null
        }

        // Method to insert a new tool in the list and maintain alphabetical order of tool name
        public void InsertNewTool(Tool tool)
    	{
            ToolNode newNode = new ToolNode(tool);

            // Check if list is empty or new tool name smaller than head tool name alphabetically. If yes new tool will be head.
            if (head == null || (newNode.ATool.CompareTo(head.ATool) < 0))
            {
                newNode.NextTool = head;
                head = newNode;
                tail = head;
            }
            else
            {
                ToolNode current = head;

                // Find the insertion point.
                while (current.NextTool != null &&
                       (newNode.ATool.CompareTo(current.NextTool.ATool) > 0))
                {
                    current = current.NextTool;
                }

                // Insert the new tool after 'current'.
                newNode.NextTool = current.NextTool;
                current.NextTool = newNode;
            }

            // Update the tail if necessary.
            if (newNode.NextTool == null)
            {
                tail = newNode;
            }

            length++;
        }

        public void IncreaseToolQuantity(Tool tool, int newQuantity)
        {
            ToolNode toolNode = SearchTool(tool);
            if (toolNode != null)
            {
                // Found the tool, so update its quantity
                toolNode.ATool.ToolQuantity += newQuantity;
            }
        }

        public void DisplayTools()
        {
            if (head == null)
            {
                WriteLine("The tool list is empty.");
                return;
            }

            ToolNode current = head;

            while (current != null)
            {
                WriteLine("Name: {0} - Description: {1} - Quantity: {2}", current.ATool.ToolName, current.ATool.ToolDescription, current.ATool.ToolQuantity);
                current = current.NextTool;
            }
        }
    }
}