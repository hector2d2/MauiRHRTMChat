using Mopups.Pages;
using Mopups.Services;

namespace RHRTMChat.Popups;

public partial class popup1: PopupPage
{
	public popup1()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        ContainerRed.HeightRequest = height * .8;
        ContainerRed.WidthRequest = width * .8;
    }

    void BtnOpenPopup_Clicked(System.Object sender, System.EventArgs e)
    {
		MopupService.Instance.PushAsync(new popup2());
    }

    void BtnClosePopup_Clicked(System.Object sender, System.EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}
