using System;
using System.Globalization;
using System.Windows.Data;

namespace HealthcareManagementSystem.Converters
{
    internal class RoleVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isChecked = (bool) value;
            if (isChecked)
                return false;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}