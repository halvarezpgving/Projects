using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view.Utilities
{
    public class Utilities_Size_Distribution : ContentPage
    {
        public Utilities_Size_Distribution()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "size distribution" }
                }
            };
        }
    }
}

