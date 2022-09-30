using System;
using CommunityToolkit.Mvvm.Input;

namespace RHRTMChat.Models
{
	public class SettingsItem
	{
		public string Name { get; set; }
		public RelayCommand OnPressed { get; set; } 
	}
}

