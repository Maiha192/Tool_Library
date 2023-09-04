using System;
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
			set { value = toolName; }
		}

		public string ToolDescription
		{
		    get { return toolDescription; }
			set { value = toolDescription; }
		}

		public int ToolQuantity
		{
		    get { return toolQuantity; }
			set { value = ToolQuantity;  }
		}

		public Tool(string toolName)
		{
			this.toolName = toolName;
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
	}
}

