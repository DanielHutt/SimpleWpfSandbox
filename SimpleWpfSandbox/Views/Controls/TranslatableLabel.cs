using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace SimpleWpfSandbox.Views.Controls
{
    public class TranslatableLabel : Label
    {
        static TranslatableLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TranslatableLabel),
                new FrameworkPropertyMetadata(typeof(TranslatableLabel)));
        }

        /// <summary>
        /// TranslationConditionProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty TranslationConditionProperty =
            DependencyProperty.Register("TranslationCondition", typeof(bool), typeof(TranslatableLabel),
                new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the TranslationCondition property. This dependency property
        /// indicates the on text.
        /// </summary>
        public bool TranslationCondition
        {
            get { return (bool)GetValue(TranslationConditionProperty); }
            set { SetValue(TranslationConditionProperty, value); }
        }

        /// <summary>
        /// TrueTranslationConditionTextProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty TrueTranslationConditionTextProperty =
            DependencyProperty.Register("TrueTranslationConditionText", typeof(string), typeof(TranslatableLabel),
                new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the TrueTranslationConditionText property. This dependency property
        /// indicates the on text.
        /// </summary>
        public string TrueTranslationConditionText
        {
            get { return (string)GetValue(TrueTranslationConditionTextProperty); }
            set { SetValue(TrueTranslationConditionTextProperty, value); }
        }

        /// <summary>
        /// FalseTranslationConditionTextProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty FalseTranslationConditionTextProperty =
            DependencyProperty.Register("FalseTranslationConditionText", typeof(string), typeof(TranslatableLabel),
                new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the FalseTranslationConditionTextProperty property. This dependency property
        /// indicates the off text.
        /// </summary>
        public string FalseTranslationConditionText
        {
            get { return (string)GetValue(FalseTranslationConditionTextProperty); }
            set { SetValue(FalseTranslationConditionTextProperty, value); }
        }
    }
}