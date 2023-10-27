using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.ATMStates
{
	public class NoCardState : IATMState
	{
		private IATMContext? _context;
		public void SetContext(IATMContext context)
		{
			_context = context;
		}

		public void GetCash()
		{
			Console.WriteLine("insert your card!");
		}

		public void InsertCard()
		{
			Console.WriteLine("card is inserted");
			_context.SetState(new InsertCardState());
		}

		public void PullOutCard()
		{
			Console.WriteLine("your card is pulled out");
			_context?.SetState(new NoCardState());
		}

		public void WriteAmount(int amount)
		{
			Console.WriteLine("insert your card!");
		}

		public void WritePIN(int pin)
		{
			Console.WriteLine("insert your card!");
		}
	}
}
