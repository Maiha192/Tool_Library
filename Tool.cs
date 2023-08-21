using System;
namespace ToolLibrary
{
	public class Tool
	{
		public string ToolName { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }

		public Tool(string name, string description, int quantity)
		{
			this.ToolName = name;
			this.Description = description;
			this.Quantity = quantity;
		}
	}
}

