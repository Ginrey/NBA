using System;
using System.Globalization;
using System.Windows.Data;
using NBAManagement.Data.Enum;

namespace NBAManagement.ViewModel.Converters
{
    public class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Roles) (int) value;
        }
    }
}
