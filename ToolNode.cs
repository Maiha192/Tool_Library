using System;
using Tool;

namespace ToolLibrary
{
	public class ToolNode
	{
	    Tool aTool;
	    Node nextTool;

	    Node(Tool tool)
	    {
	        this.aTool = tool;
	    }
	}
}