using System;
using Borrower;
using BorrowerNode;

namespace ToolLibrary
{
	public class BorrowerLinkedList
	{
	    private BorrowerNode head;
	    private BorrowerNode tail;
	    private int length;

	    public BorrowerLinkedList(Borrower borrower)
	    {
	        BorrowerNode newBorrower = new BorrowerNode(borrower);
	        head = newBorrower;
	        tail = newBorrower;
	        length = 1;
	    }

	    public void AddNewBorrower(Borrower borrower)
	    {

	    }

	    public void RemoveBorrower(Borrower borrower)
	    {

	    }
	}
}