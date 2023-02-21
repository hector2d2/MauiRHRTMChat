using Mopups.Pages;
using Mopups.Services;

namespace RHRTMChat.Popups;

public partial class popup2 : PopupPage
{
	public popup2()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
    }

    void BtnClosePopup_Clicked(System.Object sender, System.EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}
