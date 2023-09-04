using System;

namespace ToolLibrary
{
	public class BorrowerLinkedList
	{
	    private BorrowerNode head;
	    private BorrowerNode tail;
	    private int length = 0;

		public BorrowerNode Head
		{
			get { return head; }
		}

		public BorrowerNode Tail
		{
			get { return tail; }
		}

		public int Length
		{
			get { return length; }
		}
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