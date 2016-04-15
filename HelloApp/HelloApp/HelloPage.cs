using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloApp
{
    public class HelloPage : ContentPage
    {
        public HelloPage()
        {
            this.Content = new Label
            {
                Text = "Hello Xamarin Forms!",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
        }
    }
}
