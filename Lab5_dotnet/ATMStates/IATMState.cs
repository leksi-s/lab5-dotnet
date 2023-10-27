using Lab5_dotnet.Context.Context;

namespace Lab5_dotnet.ATMStates
{
	public interface IATMState
	{
		void SetContext(IATMContext context);
		void InsertCard();
		void WritePIN(int pin);
		void WriteAmount(int amount);
		void GetCash();
		void PullOutCard();
	}
}
