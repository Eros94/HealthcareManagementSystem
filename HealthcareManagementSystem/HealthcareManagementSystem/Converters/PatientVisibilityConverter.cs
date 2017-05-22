using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HealthcareManagementSystem.Converters
{
    internal class PatientVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selectedRole = (string) value;
            if (selectedRole == "Patient")
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}