using System;
namespace ToolLibrary
{
	public class Borrower
	{
		private string firstName;
		private string lastName;
		private string mobile;

		public string FirstName
		{
			get { return firstName; }
		}

		public string LastName
		{
			get { return lastName; }
		}

		public string Mobile
		{
			get { return mobile; }
		}

		public Borrower(string lastName, string firstName, string mobileNumber)
		{
			this.lastName = lastName;
			this.firstName = firstName;
			this.mobile = mobileNumber;
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

		public override string ToString()
		{
			return (firstName + " " + lastName + " " + mobile.ToString() + "\n");
		}
	}
}
