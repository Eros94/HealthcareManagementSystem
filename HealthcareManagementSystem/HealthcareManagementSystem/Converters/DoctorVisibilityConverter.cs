using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HealthcareManagementSystem.Converters
{
    internal class DoctorVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selectedRole = (string) value;
            if (selectedRole == "Doctor")
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}