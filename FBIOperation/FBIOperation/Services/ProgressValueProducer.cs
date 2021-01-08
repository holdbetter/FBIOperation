using FBIOperation.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FBIOperation.Services
{
    class ProgressValueProducer : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Stats stats = value as Stats;
                return stats.HomeValue / (float)(stats.HomeValue + stats.GuestValue);
            }
            else
            {
                return BindableProperty.UnsetValue;
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
