using RHRTMChat.ViewModel;

namespace RHRTMChat.Views;

public partial class ChatPage : ContentPage
{
	public ChatPage(VMchats vmChats)
	{
		InitializeComponent();
		BindingContext = vmChats;
	}
}
