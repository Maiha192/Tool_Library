using System;
using System.Reflection;

namespace ToolLibrary
{
	public class Tool
	{
		private string toolName;
		private string toolDescription;
		private int toolQuantity;

        public string ToolName
        {
            get { return toolName; }
            set { toolName = value; }
        }

        public string ToolDescription
        {
            get { return toolDescription; }
            set { toolDescription = value; }
        }

        public int ToolQuantity
        {
            get { return toolQuantity; }
            set { toolQuantity = value; }
        }

        public Tool(string toolName)
		{
			this.toolName = toolName;
            this.toolDescription = " ";
            this.toolQuantity = 0;
		}

        public Tool(string toolName, string description, int quantity)
        {
            this.toolName = toolName;
			this.toolDescription = description;
			this.toolQuantity = quantity;
        }

        public int CompareTo(Tool another)
        {
            if (this.ToolName.CompareTo(another.ToolName) < 0)
                return -1;
            else
                if (this.ToolName.CompareTo(another.ToolName) == 0)
					return 0;
            else
                return 1;
        }

        public bool Equals(Tool another)
        {
			return this.ToolName.Equals(another.ToolName);
        }
    }
}

