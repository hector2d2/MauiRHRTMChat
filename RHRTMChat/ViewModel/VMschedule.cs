using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RHRTMChat.Models;

namespace RHRTMChat.ViewModel
{
	[ObservableObject]
	public partial class VMschedule
	{
		[ObservableProperty]
		ObservableCollection<ScheduleModel> calendar = new();

		[ObservableProperty]
		string monthName;

		[ObservableProperty]
		int year;

        int monthNumber;

		DateTime currentDate = DateTime.Now;

        public VMschedule()
		{
            monthNumber = currentDate.Month;
            SetMonth(monthNumber);
            SetDaysOfMonth(monthNumber, currentDate.Year);
        }

		void SetDaysOfMonth(int month, int year)
		{
            var currentDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day);
            var daysOfMonth = DateTime.DaysInMonth(year, month);
            var initDateTime = new DateTime(year, month, 1);
            var dayOfWeekInit = (int)initDateTime.DayOfWeek;
            var currentDay = 1;
            Calendar.Clear();
            for (int i = 0; i < 35; i++)
            {
                string numberDay = "";
                DateTime? date = null;
                bool isToday = false;
                if (dayOfWeekInit <= i && currentDay <= daysOfMonth)
                {
                    numberDay = currentDay.ToString();
                    date = new DateTime(year, month, currentDay);
                    var differenceDate = date.Value - currentDateTime;
                    isToday = differenceDate.Days == 0;
                    currentDay++;
                }
                else
                    numberDay = "";
                var schedule = new ScheduleModel()
                {
                    NumberDay = numberDay,
                    HaveDoing = false,
                    NumberColumn = i % 7,
                    NumberRow = i >= 7 ? i / 7 : 0,
                    CurrentDate = date,
                    IsToday = isToday
                };
                Calendar.Add(schedule);
            }
        }

		void SetMonth(int numberMonth)
		{
			switch (numberMonth)
			{
				case 1:
					MonthName = "ENE";
					break;
                case 2:
                    MonthName = "FEB";
                    break;
                case 3:
                    MonthName = "MAR";
                    break;
                case 4:
                    MonthName = "ABR";
                    break;
                case 5:
                    MonthName = "MAY";
                    break;
                case 6:
                    MonthName = "JUN";
                    break;
                case 7:
                    MonthName = "JUL";
                    break;
                case 8:
                    MonthName = "AGO";
                    break;
                case 9:
                    MonthName = "SEP";
                    break;
                case 10:
                    MonthName = "OCT";
                    break;
                case 11:
                    MonthName = "NOV";
                    break;
                case 12:
                    MonthName = "DIC";
                    break;
            }            
        }

        [RelayCommand]
        void GoToScheduleDetail(ScheduleModel scheduleModel)
        {

            Shell.Current.GoToAsync("//ScheduleDetailPage");
        }

		[RelayCommand]
		void BackMonth()
		{
            if (monthNumber == 1)
                return;
			monthNumber--;
			SetMonth(monthNumber);
            SetDaysOfMonth(monthNumber, currentDate.Year);
        }

		[RelayCommand]
		void NextMonth()
		{
            if (monthNumber == 12)
                return;
            monthNumber++;
            SetMonth(monthNumber);
            SetDaysOfMonth(monthNumber, currentDate.Year);
        }
	}
}

