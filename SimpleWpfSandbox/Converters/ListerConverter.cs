using MahApps.Metro.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleWpfSandbox.Converters
{
    public class ListerConverter : MarkupConverter
    {
        protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is IList<string>)) return string.Empty;

            var serialList = (IList<string>)value;
            return serialList
                .Aggregate(string.Empty, (current, serial) => current + serial + " ");
        }

        protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return new List<string>();
            var stringer = value.ToString();

            var newstring = Regex.Split(stringer, @"\s+").ToList();
            return newstring;
        }
    }
}