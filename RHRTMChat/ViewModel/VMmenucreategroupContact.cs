using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RHRTMChat.Views;

namespace RHRTMChat.ViewModel
{
    [ObservableObject]
    public partial class VMmenucreategroupContact
    {
        [RelayCommand]
        async void GoToCreateContact()
        {
            await Shell.Current.GoToAsync(nameof(CreateNewContact));
        }
    }
}

