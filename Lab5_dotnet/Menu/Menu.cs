using Lab5_dotnet.ATMStates;
using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.Menu
{
	internal class Menu : IMenu
	{
		private IATMContext _context;
		public Menu(IATMContext context)
		{
			_context = context;
		}
		public void InsertCard()
		{
			_context.InsertCard();
		}
		public void WritePIN()
		{
			Console.WriteLine("enter your pin:");
			int pin = int.Parse(Console.ReadLine()!);
			_context.WritePIN(pin);
		}
		public void WriteAmount()
		{
			if (this._context.GetState().GetType() == typeof(CorrectPINState))
			{
				Console.WriteLine("enter amount of money:");
				int amount = int.Parse(Console.ReadLine()!);
				_context.WriteAmount(amount);
			}
		}
		public void GetCash()
		{
			_context.GetCash();
		}
		public void PullOutCard()
		{
			_context.PullOutCard();
		}
	}
}
