namespace Lab5_dotnet.User
{
	internal class UserFillingData
	{
		public static IUser GetUser()
		{
			return new User(5050666, 5000, 100, 1234);
		}
	}
}
