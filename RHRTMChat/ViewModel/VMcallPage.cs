using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using RHRTMChat.Data;
using RHRTMChat.Models;

namespace RHRTMChat.ViewModel
{
    [ObservableObject]
    public partial class VMcallPage
    {
        long ParentId = 3;


        [ObservableProperty]
        ObservableCollection<Mroutes> myMenus = new();

        public VMcallPage()
        {
            List<MskeletonRoutes> menus = UserApp.UserRoutes[ParentId].Childrens;
            foreach (var menu in menus)
            {
                MyMenus.Add(menu.Route);
            }
        }

        void BuildMenus()
        {

        }
    }
}

