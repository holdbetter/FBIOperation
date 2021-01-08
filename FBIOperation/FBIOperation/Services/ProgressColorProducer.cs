using FBIOperation.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FBIOperation.Services
{
    public class ProgressColorProducer : IMultiValueConverter
    {
        object IMultiValueConverter.Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && targetType.IsAssignableFrom(typeof(Color)))
            {
                Stats stats = values[0] as Stats;

                if (stats.HomeValue > stats.GuestValue)
                {
                    return (values[1] as MatchEvent).SportTypeColor;
                }
                else
                {
                    return Color.FromHex("#FF7676");
                }
            }
            else
            {
                return BindableProperty.UnsetValue;
            }
        }

        object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
