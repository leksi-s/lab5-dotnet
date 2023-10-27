using Lab5_dotnet.ATMStates;
using Lab5_dotnet.Context;
using Lab5_dotnet.Context.Context;
using Lab5_dotnet.Menu;

namespace Lab5_dotnet.Runner
{
	internal class Runner : IRunner
	{
		public void Run()
		{
			IATMState atmState = new NoCardState();
			IATMContext atmContext = new ATMContext(atmState);
			IMenu menu = new Menu.Menu(atmContext);

			menu.InsertCard();
			menu.WritePIN();

			menu.WriteAmount();
			menu.GetCash();
			menu.PullOutCard();
		}
	}
}
