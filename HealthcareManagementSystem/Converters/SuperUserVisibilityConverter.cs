using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HealthcareManagementSystem.Converters
{
    public class SuperUserVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isChecked = (bool) value;
            if (isChecked)
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}