using Lab5_dotnet.Context.Context;
using Lab5_dotnet.User;

namespace Lab5_dotnet.ATMStates
{
	internal class InsertCardState : IATMState
	{
		private IATMContext? _context;
		public void SetContext(IATMContext context)
		{
			_context = context;
		}

		public void InsertCard()
		{
			Console.WriteLine("card is inserted");
		}
		public void WritePIN(int pin)
		{
			Console.WriteLine("you entered your pin");
			IUser user = UserFillingData.GetUser();
			if (pin == user.GetPIN())
			{
				_context?.SetState(new CorrectPINState());
			}
			else
			{
				_context?.SetState(new IncorrectPINState());
			}

		}
		public void WriteAmount(int amount)
		{
			Console.WriteLine("enter your pin!");
		}
		public void GetCash()
		{
			Console.WriteLine("enter your pin!");
		}
		public void PullOutCard()
		{
			Console.WriteLine("card is pulled out");
			_context?.SetState(new NoCardState());
		}
	}
}
