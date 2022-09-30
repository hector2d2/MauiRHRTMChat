using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RHRTMChat.ViewModel
{
	[ObservableObject]
	public partial class VMchating
	{
		[RelayCommand]
		async void GoBack()
		{
			await Shell.Current.GoToAsync("..");
		}
	}
}

