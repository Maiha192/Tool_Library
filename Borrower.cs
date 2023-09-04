using System;
namespace ToolLibrary
{
	public class Borrower
	{
		private string firstName;
		private string lastName;
		private string mobile;
		private ToolLinkedList borrowedToolsList;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		public ToolLinkedList BorrowedToolsList
		{
			get { return borrowedToolsList; }
			set { borrowedToolsList = value; }
		}

        public Borrower(string lastName, string firstName, string mobileNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.mobile = mobileNumber;
            this.borrowedToolsList = null;
        }

        public Borrower(string lastName, string firstName, string mobileNumber, ToolLinkedList borrowedToolsList)
		{
			this.lastName = lastName;
			this.firstName = firstName;
			this.mobile = mobileNumber;
			this.borrowedToolsList = borrowedToolsList;
		}

		public int CompareTo(Borrower another)
		{
			if (this.LastName.CompareTo(another.LastName) < 0)
				return -1;
			else
				if (this.LastName.CompareTo(another.LastName) == 0)
				return this.FirstName.CompareTo(another.FirstName);
			else
				return 1;
		}
	}
}