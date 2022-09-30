using RHRTMChat.ViewModel;

namespace RHRTMChat.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(VMsettings vmSettings)
	{
		InitializeComponent();
		BindingContext = vmSettings;
	}


}
