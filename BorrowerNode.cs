using System;
using Borrower;

namespace ToolLibrary
{
	public class BorrowerNode
	{
	    Borrower aBorrower;
	    Node nextBorrower;

	    Node(Borrower borrower)
	    {
	        this.aBorrower = borrower;
	    }
	}
}