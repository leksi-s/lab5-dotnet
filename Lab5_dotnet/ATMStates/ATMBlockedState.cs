using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.ATMStates
{
	internal class ATMBlockedState : IATMState
	{
		private IATMContext? _context;
		public void GetCash()
		{
			Console.WriteLine("atm is blocked");
		}

		public void InsertCard()
		{
			Console.WriteLine("atm is blocked");
		}

		public void PullOutCard()
		{
			Console.WriteLine("atm is blocked");
		}

		public void SetContext(IATMContext context)
		{
			_context = context;
		}

		public void WriteAmount(int amount)
		{
			Console.WriteLine("atm is blocked");
		}

		public void WritePIN(int pin)
		{
			Console.WriteLine("atm is blocked");
		}
	}
}
