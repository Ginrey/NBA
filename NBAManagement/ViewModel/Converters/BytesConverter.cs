using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Data;

namespace NBAManagement.ViewModel.Converters
{
    public class BytesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bytes = (byte[]) value;
            if (bytes.Length == 0)
                return null;
            return (Image) new ImageConverter().ConvertFrom(bytes);
        }
    }
}
