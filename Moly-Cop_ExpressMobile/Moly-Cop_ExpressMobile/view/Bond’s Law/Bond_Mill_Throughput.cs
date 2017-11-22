using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view
{
    public class Bond_Mill_Throughput : ContentPage
    {
        public Bond_Mill_Throughput()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Bond_Mill Throughput" }
                }
            };
        }
    }
}

