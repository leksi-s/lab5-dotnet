using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.ATMStates
{
	internal class GetCashState : IATMState
	{
		private IATMContext? _context;
		public void SetState(IATMContext context)
		{
			_context = context;
		}

		public void GetCash()
		{
			Console.WriteLine("get your cash");
		}

		public void InsertCard()
		{
			Console.WriteLine("your card is inserted");

		}
		public void WritePIN(int pin)
		{
			Console.WriteLine("pin is already entered");
		}

		public void PullOutCard()
		{
			Console.WriteLine("card is pulled out");
			_context?.SetState(new NoCardState());
		}

		public void WriteAmount(int amount)
		{
			Console.WriteLine("amount is already written");
		}

		public void SetContext(IATMContext context)
		{
			_context = context;
		}
	}
}
