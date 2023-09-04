using System;

namespace ToolLibrary
{
	public class BorrowerNode
	{
	    private Borrower aBorrower;
	    private BorrowerNode nextBorrower;

	    public BorrowerNode(Borrower borrower)
	    {
	        this.aBorrower = borrower;
	        this.nextBorrower = null;
	    }

	    public Borrower ABorrower
	    {
	        get { return aBorrower; }
	        set { aBorrower = value; }
	    }

	    public BorrowerNode NextBorrower
	    {
	        get { return nextBorrower; }
	        set { nextBorrower = value; }
	    }
	}
}