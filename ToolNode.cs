using System;
using Tool;

namespace ToolLibrary
{
	public class ToolNode
	{
	    private Tool aTool;
	    private ToolNode nextTool;

	    public ToolNode(Tool tool)
	    {
	        this.aTool = tool;
	        this.nextTool = null;
	    }

	    public Tool ATool
	    {
	        get { return aTool; }
	        set { aTool = value; }
	    }

	    public ToolNode NextTool
	    {
	        get { return nextTool; }
	        set { nextTool = value; }
	    }
	}
}