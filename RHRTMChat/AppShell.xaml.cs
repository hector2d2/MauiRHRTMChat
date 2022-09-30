using RHRTMChat.Views;

namespace RHRTMChat;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ChatingPage), typeof(ChatingPage));
	}
}

