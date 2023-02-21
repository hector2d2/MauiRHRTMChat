using Mopups.Services;
using RHRTMChat.Popups;

namespace RHRTMChat.Views;

public partial class AnimationGif : ContentPage
{
	public AnimationGif()
	{
		InitializeComponent();
	}

    void BtnOpenPopup_Clicked(System.Object sender, System.EventArgs e)
    {
		MopupService.Instance.PushAsync(new popup1());
    }
}
