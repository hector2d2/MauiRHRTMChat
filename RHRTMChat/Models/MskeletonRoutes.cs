using System;
namespace RHRTMChat.Models
{
    public class MskeletonRoutes
    {
        public Mroutes Route { set; get; }
        public List<MskeletonRoutes> Childrens { set; get; } 
    }
}

