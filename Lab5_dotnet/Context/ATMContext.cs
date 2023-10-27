using Lab5_dotnet.ATMStates;
using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.Context
{
	public class ATMContext : IATMContext
	{
		private IATMState? _state { get; set; }
		public ATMContext(IATMState state)
		{
			SetState(state);
		}
		public void SetState(IATMState state)
		{
			_state = state;
			_state.SetContext(this);
		}

		public IATMState GetState()
		{
			return _state;
		}

		public void InsertCard()
		{
			_state?.InsertCard();

		}
		public void WritePIN(int pin)
		{
			_state?.WritePIN(pin);
		}
		public void WriteAmount(int amount)
		{
			_state?.WriteAmount(amount);
		}
		public void GetCash()
		{
			_state?.GetCash();
		}
		public void PullOutCard()
		{
			_state?.PullOutCard();
		}
	}
}
