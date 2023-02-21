using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Devices.Sensors;

namespace RHRTMChat.ViewModel
{
	[ObservableObject]
	public partial class VMcamera
	{
		[ObservableProperty]
		ObservableCollection<Location> locations;
	}
}

