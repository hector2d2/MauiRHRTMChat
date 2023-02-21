using System;
using CommunityToolkit.Mvvm.Messaging.Messages;
using RHRTMChat.Models;

namespace RHRTMChat.Messenger
{
    public class RoutesMessage : ValueChangedMessage<List<Mroutes>>
    {
        public RoutesMessage(List<Mroutes> value) : base(value)
        {
        }
    }
}

