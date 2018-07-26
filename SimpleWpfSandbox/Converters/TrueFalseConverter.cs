using SimpleWpfSandbox.Views.Resources;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace SimpleWpfSandbox.Converters
{
    [ValueConversion(typeof(bool), typeof(string))]
    public class TrueFalseTextConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(Boolean))
                throw new InvalidOperationException("The value must be a boolean");

            return (bool)value
                ? Rez.TrueString
                : Rez.FalseString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}