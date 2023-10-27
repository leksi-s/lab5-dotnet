using Lab5_dotnet.ATMStates;

namespace Lab5_dotnet.Context.Context
{
	public interface IATMContext
	{
		void SetState(IATMState state);
		IATMState GetState();
		void InsertCard();
		void WritePIN(int pin);
		void WriteAmount(int amount);
		void GetCash();
		void PullOutCard();
	}
}
