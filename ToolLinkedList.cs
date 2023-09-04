using System;
using Tool;
using ToolNode;

namespace ToolLibrary
{
	public class ToolLinkedList
    	{
    	    private ToolNode head;
    	    private ToolNode tail;
    	    private int length;

    	    public ToolLinkedList(Tool tool)
    	    {
    	        ToolNode newTool = new ToolNode(tool);
    	        head = newTool;
    	        tail = newTool;
    	        length = 1;
    	    }

    	    public void AddNewTool(Tool tool)
    	    {

    	    }

    	    public void RemoveTool(Tool tool)
    	    {

    	    }
    	}
}