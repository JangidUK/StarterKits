﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

//
// LICENSE: http://opensource.org/licenses/ms-pl) 
//

namespace APIMASH_StarterKit.Common
{
    /// <summary>
    /// Value converter that the more common types to Visibility values
    /// </summary>
    public sealed class BasicTypeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Boolean)
                return ((Boolean)value) ? Visibility.Visible : Visibility.Collapsed;

            if (value is String)
                return String.IsNullOrEmpty(value as String) ? Visibility.Collapsed : Visibility.Visible;

            if (value is Int32)
                return ((Int32)value == 0) ? Visibility.Collapsed : Visibility.Visible;

            if (value is Double)
                return ((Int32)value == 0) ? Visibility.Collapsed : Visibility.Visible;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
        }
    }
}
