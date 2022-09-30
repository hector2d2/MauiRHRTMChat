using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RHRTMChat.Views;

namespace RHRTMChat.ViewModel
{
	[ObservableObject]
	public partial class VMchats
	{
		[RelayCommand]
		async void GoToChat()
		{
			await Shell.Current.GoToAsync(nameof(ChatingPage));
		}
	}
}

