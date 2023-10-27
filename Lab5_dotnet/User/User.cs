namespace Lab5_dotnet.User
{
	internal class User : IUser
	{
		public int CardNum { get; }
		public int Restriction { get; }
		public int Balance { get; set; }
		public int PIN { get; }

		public User(int cardNum, int restriction, int balance, int pin)
		{
			CardNum = cardNum;
			Restriction = restriction;
			Balance = balance;
			PIN = pin;
		}

		public int GetCardNum()
		{
			return CardNum;
		}

		public int GetRestriction()
		{
			return Restriction;
		}

		public int GetBalance()
		{
			return Balance;
		}

		public int GetPIN()
		{
			return PIN;
		}
	}
}
