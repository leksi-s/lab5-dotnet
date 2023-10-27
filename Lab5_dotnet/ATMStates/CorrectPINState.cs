
using Lab5_dotnet.Context.Context;
using Lab5_dotnet.User;

namespace Lab5_dotnet.ATMStates
{
	internal class CorrectPINState : IATMState
	{
		private IATMContext? _context;

		public void InsertCard()
		{
			Console.WriteLine("your card is inserted");
		}
		public void WritePIN(int pin)
		{
			Console.WriteLine("pin is already entered");
		}
		public void WriteAmount(int amount)
		{
			IUser user = UserFillingData.GetUser();

			if (amount < user.GetRestriction() && user.GetBalance() - amount > 0)
			{
				Console.WriteLine("you can get your money");
				_context?.SetState(new GetCashState());
			}
			else
			{
				Console.WriteLine("you entered too much money");
				_context?.SetState(new OutOfLimitState());
			}
		}
		public void GetCash()
		{
			Console.WriteLine("write amount of money to get the cash");
		}
		public void PullOutCard()
		{
			Console.WriteLine("card is pulled out");
			_context?.SetState(new NoCardState());
		}

		public void SetContext(IATMContext context)
		{
			_context = context;
		}
	}
}
