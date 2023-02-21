using System;
namespace RHRTMChat.Models
{
	public class Mroutes
	{
		public long IdProyecto { set; get; }
		public long IdGrupo { set; get; }
		public string Text { set; get; }
		public long MenuId { set; get; }
		public long ParentId { set; get; }
		public string ImagePath { set; get; }
		public string NavigateUrl { set; get; }
	}
}

