namespace RHRTMChat.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync("//Home");
    }
}
