using System;
using System.Linq;
using System.Windows.Markup;

namespace SimpleWpfSandbox.Converters
{
    public class EnumToItemsSource : MarkupExtension
    {
        private readonly Type _type;

        public EnumToItemsSource(Type type)
        {
            _type = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider) =>
            Enum.GetValues(_type);
    }
}
