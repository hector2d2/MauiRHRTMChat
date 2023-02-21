using System;
namespace RHRTMChat.Models
{
	public class ScheduleModel
	{
		public string NumberDay { get; set; }
		public int NumberRow { get; set; }
		public int NumberColumn { get; set; }
		public bool HaveDoing { get; set; }
		public DateTime? CurrentDate { get; set; }
		public bool IsToday { get; set; }
	}
}

