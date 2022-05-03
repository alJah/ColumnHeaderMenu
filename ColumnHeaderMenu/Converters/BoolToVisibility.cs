using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Windows.Data;
using System.Threading.Tasks;
using System.Globalization;

namespace ColumnHeaderMenu.Converters
{
    [ValueConversion(typeof(Boolean), typeof(Visibility))]
    internal class BoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Visibility)value == Visibility.Visible) return true; return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Boolean)value) return Visibility.Visible; return Visibility.Collapsed;
        }
    }
}
