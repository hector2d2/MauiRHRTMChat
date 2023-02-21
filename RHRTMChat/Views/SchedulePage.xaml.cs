using RHRTMChat.ViewModel;

namespace RHRTMChat.Views;

public partial class SchedulePage : ContentPage
{
	public SchedulePage(VMschedule vMschedule)
	{
		InitializeComponent();
		BindingContext = vMschedule;
	}
}
