using System;
using RHRTMChat.Views;

namespace RHRTMChat
{
	public static class AppRoutes
	{
		public static Dictionary<string, DataTemplate> Routes = new Dictionary<string, DataTemplate>
		{
            {
                "ScheduleDetailPage" ,
                new DataTemplate(() => new ScheduleDetailPage())
            },
            {
                "SchedulePage" ,
                new DataTemplate(() => new SchedulePage(new ViewModel.VMschedule()))
            },
            {
                "StatusPage" ,
				new DataTemplate(() => new StatusPage())
			},
            {
                "CallPage" ,
                new DataTemplate(() => new CallPage())
            },
            {
                "CameraPage" ,
                new DataTemplate(() => new CameraPage())
            },
            {
                "ChatPage" ,
                new DataTemplate(() => new ChatPage(new ViewModel.VMchats()))
            },
            {
                "SettingsPage" ,
                new DataTemplate(() => new SettingsPage(new ViewModel.VMsettings()))
            },
            {
                "CallPage/Add" ,
                new DataTemplate(() => new CallPageAdd())
            },
            {
                "CallPage/Delete" ,
                new DataTemplate(() => new CallPageDelete())
            },
            {
                "Chat/ChatingPage" ,
                new DataTemplate(() => new ChatingPage(new ViewModel.VMchating()))
            },
            {
                "Gif" ,
                new DataTemplate(() => new AnimationGif())
            },
        };
	}
}

