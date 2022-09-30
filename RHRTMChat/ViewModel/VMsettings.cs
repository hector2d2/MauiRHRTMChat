using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RHRTMChat.Models;

namespace RHRTMChat.ViewModel
{
    [ObservableObject]
    public partial class VMsettings
    {

        [RelayCommand]
        void ChangeTheme()
        {
            Application.Current.UserAppTheme = Application.Current.UserAppTheme == AppTheme.Light ? AppTheme.Dark : AppTheme.Light;
        }
    }
}

