using System;
namespace ToolLibrary
{
	public class Borrower
	{
		private string firstName;
		private string lastName;
		private int mobile;

		public string FirstName
		{
			get { return firstName; }
			set { value = firstName; }
		}

		public string LastName
		{
			get { return lastName; }
			set { value = lastName; }
		}

		public int Mobile
		{
			get { return mobile; }
			set { value = mobile; }
		}

		public Borrower(string lastName, string firstName, int mobileNumber)
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
