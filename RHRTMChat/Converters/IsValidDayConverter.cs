using System;
using System.Globalization;

namespace RHRTMChat.Converters
{
	public class IsValidDayConverter: IValueConverter
	{
		public IsValidDayConverter()
		{
		}

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            if (value == "")
                return false;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

