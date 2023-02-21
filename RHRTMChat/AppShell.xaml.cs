using CommunityToolkit.Mvvm.Messaging;
using RHRTMChat.Data;
using RHRTMChat.Messenger;
using RHRTMChat.Models;
using RHRTMChat.Views;

namespace RHRTMChat;

public partial class AppShell : Shell, IRecipient<RoutesMessage>
{
	public AppShell()
	{
		InitializeComponent();
        WeakReferenceMessenger.Default.Register<RoutesMessage>(this);
        //Routing.RegisterRoute(nameof(ChatingPage), typeof(ChatingPage));
        //      Routing.RegisterRoute(nameof(MenuCreateGroupContact), typeof(MenuCreateGroupContact));
        //      Routing.RegisterRoute(nameof(CreateNewContact), typeof(CreateNewContact));
    }

    public void Receive(RoutesMessage message)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            List<Mroutes> routes = message.Value;
            int indexTabbar = -1;
            List<TabBar> Tabbars = new();
            foreach (var route in routes)
            {
                if(route.MenuId == route.ParentId)
                {
                    indexTabbar++;
                    TabBar tabBar = new TabBar
                    {
                        Route = route.NavigateUrl,
                        Title = route.Text
                    };
                    Tabbars.Add(tabBar);
                UserApp.UserRoutes.Add(
                        route.MenuId,
                        new MskeletonRoutes
                        {
                            Route = route, 
                            Childrens = new List<MskeletonRoutes>()
                        });
                }
                else if (UserApp.UserRoutes.ContainsKey(route.ParentId))
                {
                    ShellContent tab = new ShellContent
                    {
                        Title = route.Text,
                        Icon = route.ImagePath,
                        Route = route.NavigateUrl,
                        ContentTemplate = AppRoutes.Routes[route.NavigateUrl]
                    };
                    Tabbars[indexTabbar].Items.Add(tab);
                    UserApp.UserRoutes[route.ParentId].Childrens.Add(new MskeletonRoutes
                    {
                        Route = route,
                        Childrens = new()
                    });
                    UserApp.UserRoutes.Add(
                        route.MenuId,
                        new MskeletonRoutes
                        {
                            Route = route,
                            Childrens = new List<MskeletonRoutes>()
                        });
                }
                else
                {
                    ShellContent content = new ShellContent
                    {
                        Title = route.Text,
                        Icon = route.ImagePath,
                        Route = route.NavigateUrl,
                        ContentTemplate = AppRoutes.Routes[route.NavigateUrl]                        
                    };
                    Shell.Current.Items.Add(content);
                }
            }
            Shell.Current.Items.Add(Tabbars[0]);
        });
    }
}

