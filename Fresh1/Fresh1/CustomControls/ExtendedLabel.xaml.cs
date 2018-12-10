using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh1.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExtendedLabel : ContentView
    {
        public ExtendedLabel()
        {
            InitializeComponent();
        }

        #region Bindable Properties
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(ExtendedLabel), default(string));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty BorderThicknessProperty = BindableProperty.Create("BorderThickness", typeof(Thickness), typeof(ExtendedLabel), default(Thickness));
        public Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create("BorderColor", typeof(Color), typeof(ExtendedLabel), default(Color));
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BackgroundContentColorProperty = BindableProperty.Create("BackgroundContentColor", typeof(Color), typeof(ExtendedLabel), default(Color));
        public Color BackgroundContentColor
        {
            get { return (Color)GetValue(BackgroundContentColorProperty); }
            set { SetValue(BackgroundContentColorProperty, value); }
        }

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create("CornerRadius", typeof(float), typeof(ExtendedLabel), default(float));
        public float CornerRadius
        {
            get { return (float)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(ExtendedLabel), default(Color));
        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly BindableProperty HasShadowProperty = BindableProperty.Create("HasShadow", typeof(bool), typeof(ExtendedLabel), default(bool));
        public bool HasShadow
        {
            get { return (bool)GetValue(HasShadowProperty); }
            set { SetValue(HasShadowProperty, value); }
        }

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create("FontFamily", typeof(string), typeof(ExtendedLabel), default(string));
        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(ExtendedLabel), default(double));
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty FontProperty = BindableProperty.Create("Font", typeof(Font), typeof(ExtendedLabel), default(Font));
        public Font Font
        {
            get { return (Font)GetValue(FontProperty); }
            set { SetValue(FontProperty, value); }
        }

        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create("FontAttributes", typeof(FontAttributes), typeof(ExtendedLabel), default(FontAttributes));
        public FontAttributes FontAttributes
        {
            get { return (FontAttributes)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        public static readonly BindableProperty LabelHorizontalAlignmentProperty = BindableProperty.Create("LabelHorizontalAlignment", typeof(LayoutOptions), typeof(ExtendedLabel), default(LayoutOptions));
        public LayoutOptions LabelHorizontalAlignment
        {
            get { return (LayoutOptions)GetValue(LabelHorizontalAlignmentProperty); }
            set { SetValue(LabelHorizontalAlignmentProperty, value); }
        }

        public static readonly BindableProperty LabelVerticalAlignmentProperty = BindableProperty.Create("LabelVerticalAlignment", typeof(LayoutOptions), typeof(ExtendedLabel), LayoutOptions.Center);
        public LayoutOptions LabelVerticalAlignment
        {
            get { return (LayoutOptions)GetValue(LabelVerticalAlignmentProperty); }
            set { SetValue(LabelVerticalAlignmentProperty, value); }
        }

        public static readonly BindableProperty LabelTextHorizontalAlignmentProperty = BindableProperty.Create("LabelTextHorizontalAlignment", typeof(TextAlignment), typeof(ExtendedLabel), default(TextAlignment));
        public TextAlignment LabelTextHorizontalAlignment
        {
            get { return (TextAlignment)GetValue(LabelTextHorizontalAlignmentProperty); }
            set { SetValue(LabelTextHorizontalAlignmentProperty, value); }
        }

        public static readonly BindableProperty LabelTextVerticalAlignmentProperty = BindableProperty.Create("LabelTextVerticalAlignment", typeof(TextAlignment), typeof(ExtendedLabel), default(TextAlignment));
        public TextAlignment LabelTextVerticalAlignment
        {
            get { return (TextAlignment)GetValue(LabelTextVerticalAlignmentProperty); }
            set { SetValue(LabelTextVerticalAlignmentProperty, value); }
        }

        public static readonly BindableProperty LabelMarginProperty = BindableProperty.Create("LabelMargin", typeof(Thickness), typeof(ExtendedLabel), new Thickness(5));
        public Thickness LabelMargin
        {
            get { return (Thickness)GetValue(LabelMarginProperty); }
            set { SetValue(LabelMarginProperty, value); }
        }
        #endregion
    }
}