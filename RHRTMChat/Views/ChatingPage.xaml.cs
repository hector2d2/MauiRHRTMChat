using RHRTMChat.ViewModel;

namespace RHRTMChat.Views;

public partial class ChatingPage : ContentPage
{
	public ChatingPage(VMchating vmChating)
	{
		InitializeComponent();
		BindingContext = vmChating;
	}
}
