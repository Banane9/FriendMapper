using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;

namespace FriendMapper.ValueConverters
{
    [ValueConversion(typeof(string), typeof(bool))]
    public class StringToIsNullOrWhitespaceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.IsNullOrWhiteSpace((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}