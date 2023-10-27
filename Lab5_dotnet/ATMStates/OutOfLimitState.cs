using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.ATMStates
{
	internal class OutOfLimitState : IATMState
	{
		private IATMContext? _context;
		public void SetContext(IATMContext context)
		{
			_context = context;
		}
		public void InsertCard()
		{
			Console.WriteLine("your card is inserted");

		}
		public void WritePIN(int pin)
		{
			Console.WriteLine("pin is already entered");
		}
		public void GetCash()
		{
			Console.WriteLine("you are out of your card limit");
		}

		public void PullOutCard()
		{
			Console.WriteLine("card is pulled out");
			_context?.SetState(new NoCardState());
		}

		public void WriteAmount(int amount)
		{
			Console.WriteLine("amount is written");
		}

	}
}
