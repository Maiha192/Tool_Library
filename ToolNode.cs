using System;

namespace ToolLibrary
{
	public class ToolNode
	{
	    private Tool aTool;
	    private ToolNode nextTool;

	    
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

        public ToolNode(Tool tool)
        {
            this.aTool = tool;
            this.nextTool = null;
        }

     //   public int CompareTo(ToolNode another)
     //   {
     //       if (this.ATool.CompareTo(another.ATool) < 0)
     //           return -1;
     //       else
     //           if (this.ATool.CompareTo(another.ATool) == 0)
					//return 0;
     //       else
     //           return 1;
     //   }
    }
}