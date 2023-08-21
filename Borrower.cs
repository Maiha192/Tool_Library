using System;
namespace ToolLibrary
{
	public class Borrower
	{
	
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
		public Borrower(string fullName, string phoneNumber)
		{
			this.FullName = fullName;
			this.PhoneNumber = phoneNumber;
		}
	}
}

