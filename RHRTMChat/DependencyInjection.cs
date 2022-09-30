using System;
using RHRTMChat.ViewModel;
using RHRTMChat.Views;

namespace RHRTMChat
{
	public static class DependencyInjection
	{
		public static void Init(IServiceCollection service)
		{
            //ViewModal
            service.AddSingleton<VMsettings>();
            service.AddSingleton<VMchats>();
            service.AddSingleton<VMchating>();

            // Views
            service.AddSingleton<SettingsPage>();
            service.AddSingleton<ChatPage>();
            service.AddSingleton<ChatingPage>();
        }
	}
}

