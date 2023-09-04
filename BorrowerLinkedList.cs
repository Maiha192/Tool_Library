using System;
using static System.Console;

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
			set { head = value; }
		}

		public BorrowerNode Tail
		{
			get { return tail; }
			set { tail = value; }
		}

		public int Length
		{
			get { return length; }
			set { length = value; }
		}
	    public BorrowerLinkedList(Borrower borrower)
	    {
	        BorrowerNode newBorrower = new BorrowerNode(borrower);
	        head = newBorrower;
	        tail = newBorrower;
	        length = 1;
	    }

        public BorrowerNode SearchBorrower(Borrower borrower)
        {
            BorrowerNode current = Head;
            while (current != null)
            {
                if (borrower.CompareTo(current.ABorrower) == 0)
                {
                    return current; // Found the borrower, so return the BorrowerNode
                }
                current = current.NextBorrower;
            }
            return null; // Tool not found, return null
        }

        public void AddNewBorrower(Borrower borrower)
	    {
            BorrowerNode newNode = new BorrowerNode(borrower);

            // Check if head is empty, if yes, add new borrower to head
            if (head == null)
            {
                head = newNode;
            }
            else
                if (newNode.ABorrower.CompareTo(head.ABorrower) < 0)
            {
                newNode.NextBorrower = head;
                head = newNode;
            }
            else
            {
                BorrowerNode current = head;

                // Find the insertion point.
                while (current.NextBorrower != null &&
                       (newNode.ABorrower.CompareTo(current.NextBorrower.ABorrower) > 0))
                {
                    current = current.NextBorrower;
                }

                // Insert the new borrower after 'current'.
                newNode.NextBorrower = current.NextBorrower;
                current.NextBorrower = newNode;
            }

            // Update the tail if necessary.
            if (newNode.NextBorrower == null)
            {
                tail = newNode;
            }

            length++;
        }

        public void RemoveBorrower(Borrower borrower)
        {
            // Check if the borrower to remove is the head node
            if (head.ABorrower.CompareTo(borrower) == 0)
            {
                head = head.NextBorrower;
                length--;
                WriteLine("Borrower removed from the borrower list.");
                return;
            }

            // Traverse the list to find the borrower node before the one to remove
            BorrowerNode previous = head;
            BorrowerNode current = head.NextBorrower;

            while (current != null)
            {
                if (current.ABorrower.CompareTo(borrower) == 0)
                {
                    previous.NextBorrower = current.NextBorrower;
                    length--;
                    WriteLine("Borrower removed from the borrower list.");
                    return;
                }

                previous = current;
                current = current.NextBorrower;
            }   
        }
    }
}