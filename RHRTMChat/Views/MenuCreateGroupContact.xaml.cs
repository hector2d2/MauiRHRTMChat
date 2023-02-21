using RHRTMChat.ViewModel;

namespace RHRTMChat.Views;

public partial class MenuCreateGroupContact : ContentPage
{
	public MenuCreateGroupContact(VMmenucreategroupContact vMmenucreategroupContact)
	{
		InitializeComponent();
		BindingContext = vMmenucreategroupContact;
	}
}
