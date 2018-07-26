using System.Windows;
using System.Windows.Controls.Primitives;

namespace SimpleWpfSandbox.Views.Controls
{
    public class TextedToggleButton : ToggleButton
    {
        static TextedToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextedToggleButton), new FrameworkPropertyMetadata(typeof(TextedToggleButton)));
        }

        /// <summary>
        /// CheckedText Dependency Property
        /// </summary>
        public static readonly DependencyProperty CheckedTextProperty =
            DependencyProperty.Register("CheckedText", typeof(string), typeof(TextedToggleButton),
                new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the CheckedText property. This dependency property
        /// indicates the on text.
        /// </summary>
        public string CheckedText
        {
            get { return (string)GetValue(CheckedTextProperty); }
            set { SetValue(CheckedTextProperty, value); }
        }

        /// <summary>
        /// UncheckedText Dependency Property
        /// </summary>
        public static readonly DependencyProperty UncheckedTextProperty =
            DependencyProperty.Register("UncheckedText", typeof(string), typeof(TextedToggleButton),
                new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the UncheckedText property. This dependency property
        /// indicates the off text.
        /// </summary>
        public string UncheckedText
        {
            get { return (string)GetValue(UncheckedTextProperty); }
            set { SetValue(UncheckedTextProperty, value); }
        }
    }
}