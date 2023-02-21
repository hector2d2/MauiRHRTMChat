namespace RHRTMChat.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
		BindingContext = new ViewModel.VMlogin();
	}
}
