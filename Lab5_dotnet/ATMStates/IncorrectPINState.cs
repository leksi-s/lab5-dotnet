using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.ATMStates
{
	internal class IncorrectPINState : IATMState
	{
		private IATMContext? _context;

		public void SetContext(IATMContext context)
		{
			_context = context;
		}

		public void GetCash()
		{
			Console.WriteLine("your pin is not right!");
		}

		public void InsertCard()
		{
			Console.WriteLine("card is inserted");
		}

		public void PullOutCard()
		{
			Console.WriteLine("card is pulled out");
			_context?.SetState(new NoCardState());
		}

		public void WriteAmount(int amount)
		{
			Console.WriteLine("your pin is not right!");
		}

		public void WritePIN(int pin)
		{
			Console.WriteLine("pin is entered");
		}
	}
}
