using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using RHRTMChat.Messenger;
using RHRTMChat.Models;

namespace RHRTMChat.ViewModel
{
	[ObservableObject]
	public partial class VMlogin
	{
		List<Mroutes> MyRoutes = new List<Mroutes>
		{
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 1,
                Text = "Menu Home",
                ImagePath = "",
                NavigateUrl = "Home",
                ParentId = 1
            },
            new Mroutes
			{
				IdProyecto = 77,
				IdGrupo = 1,
				MenuId = 2,
				Text = "Estados",
				ImagePath = "status",
				NavigateUrl = "StatusPage",
				ParentId = 1				
			},
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 3,
                Text = "Llamadas",
                ImagePath = "telephone",
                NavigateUrl = "CallPage",
                ParentId = 1
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 4,
                Text = "Camara",
                ImagePath = "camera",
                NavigateUrl = "CameraPage",
                ParentId = 1
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 5,
                Text = "Chats",
                ImagePath = "chat",
                NavigateUrl = "ChatPage",
                ParentId = 1
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 6,
                Text = "Configuracioón",
                ImagePath = "settings",
                NavigateUrl = "SettingsPage",
                ParentId = 1
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 7,
                Text = "Agregar",
                ImagePath = "",
                NavigateUrl = "CallPage/Add",
                ParentId = 3
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 8,
                Text = "Eliminar",
                ImagePath = "",
                NavigateUrl = "CallPage/Delete",
                ParentId = 3
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 9,
                Text = "Chat",
                ImagePath = "",
                NavigateUrl = "Chat/ChatingPage",
                ParentId = 5
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 10,
                Text = "Calendario",
                ImagePath = "",
                NavigateUrl = "SchedulePage",
                ParentId = 9999
            },
            new Mroutes
            {
                IdProyecto = 77,
                IdGrupo = 1,
                MenuId = 11,
                Text = "Calendario",
                ImagePath = "",
                NavigateUrl = "ScheduleDetailPage",
                ParentId = 9998
            }
        }; 

        void BuildRoutesOfEmployee()
		{
            WeakReferenceMessenger.Default.Send(new RoutesMessage(MyRoutes));
        }

        [RelayCommand]
        async void SignIn()
        {
            BuildRoutesOfEmployee();
            await Shell.Current.GoToAsync("//Home");
        }
	}
}

