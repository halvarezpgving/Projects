using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view
{
    public class UtilList : ContentPage
    {
        public UtilList()
        {
            Content = new StackLayout
            {/*menu con desplegables item/subitem*/
                Children = {
                    new Label { Text = "list de utilidades" }
                }
            };
        }
    }
}

