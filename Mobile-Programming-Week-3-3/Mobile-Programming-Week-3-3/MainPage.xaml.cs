using System;
using System.Linq;
using Xamarin.Forms;

namespace Mobile_Programming_Week_3_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var formattedString = new FormattedString();

            NamedSize[] namedSizes = new NamedSize[]
            {
                NamedSize.Micro,
                NamedSize.Small,
                NamedSize.Default,
                NamedSize.Medium,
                NamedSize.Large
            };

            foreach (var namedSize in namedSizes)
            {
                var fntSize = Device.GetNamedSize(namedSize, typeof(Label));
                formattedString.Spans.Add(
                    new Span
                    {
                        Text = String.Format("{0} için Font Size Değeri = {1:F2}\n", namedSize, fntSize),
                        FontSize = fntSize
                    });
                if (namedSize != namedSizes.Last())
                {
                    formattedString.Spans.Add(new Span
                    {
                        Text = Environment.NewLine + Environment.NewLine
                    });
                }
            }

            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            InitializeComponent();
        }
    }
}