using System;
namespace ToolLibrary
{
	public class Tool
	{
		private string toolName;
		private string description;
		private int quantity;

		public string ToolName
		{
            get { return toolName;}
            set { value = toolName;}
		}

		public string Description
		{
		    get { return description; }
		    set { value = description; }
		}

		public int Quantity
		{
		    get { return quantity; }
		    set { value = quantity; }
		}

		public override string ToString()
		{
		    return ("Name: " + toolName + " - Description: " + description + " - Quantity: " + quantity);
		}
	}
}

