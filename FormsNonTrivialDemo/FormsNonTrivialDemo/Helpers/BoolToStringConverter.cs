﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace FormsNonTrivialDemo.Helpers
{
    [TypeConverter(typeof(string))]
    public sealed class BoolToStringConverter : IValueConverter
    {
        public string TrueString { get; set; }
        public string FalseString { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? TrueString : FalseString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
