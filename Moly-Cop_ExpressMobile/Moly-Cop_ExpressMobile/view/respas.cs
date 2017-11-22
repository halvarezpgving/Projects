using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view
{
    public class respas : ContentPage
    {
        public respas()
        {
            /*especificacion de botones y de los tamaños del grid para odenar los elementos*/
            var btnrec = new Button { Text = "Reset Password" };
            var us = new Entry { Placeholder = "example@example.com" };
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(35, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(15, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(15, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(35, GridUnitType.Star) });
            grid.Children.Add(us, 0, 1);
            grid.Children.Add(btnrec, 0, 2);



  

            Content = grid;//se entrega grid para que sea visualizado
            

        }
    }
}

