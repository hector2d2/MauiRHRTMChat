using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RHRTMChat.Models;

namespace RHRTMChat.ViewModel
{
    [ObservableObject]
    public partial class VMonBoarding
    {
        [ObservableProperty]
        ObservableCollection<MonBoarningItems> onBoardingItems;

        public VMonBoarding()
        {
            SetItems();
        }

        void SetItems()
        {
            OnBoardingItems = new ObservableCollection<MonBoarningItems>
            {
                new MonBoarningItems
                {
                    PathImage = "login",
                    Description = "Bienvenido a Sanborns Mi espacio Mobile, Inicia Sesión con tu numero de empleado y tu contraseña.",
                    IsFinalView = false
                },
                new MonBoarningItems
                {
                    PathImage = "registroasistencia",
                    Description = "Registra tu asistencia, solo es necesario permitir acceder a tu ubicación.",
                    IsFinalView = false
                },
                new MonBoarningItems
                {
                    PathImage = "realizarencuestas",
                    Description = "Realiza tus encuestas.",
                    IsFinalView = false
                },
                new MonBoarningItems
                {
                    PathImage = "gafete",
                    Description = "Muestra tu codigo para tus descuentos de empleado.",
                    IsFinalView = true
                }
            };
        }

        [RelayCommand]
        void GoToHomePage()
        {
            Shell.Current.GoToAsync("//Login");
        }
    }
}

