using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view
{
    public class Login : ContentPage
    {
        public Login()
        {/*especificacion de botones y de los tamaños del grid para odenar los elementos*/
            var btnlog = new Button { Text = "Log In"  };
            var btncre = new Button { Text = "Create Account" };
            var us = new Entry { Placeholder = "example@example.com" };
            var pa = new Entry { Placeholder = "password" };
            var restPas = new Button { Text = "Forgot Your Password?" };
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition{Width = new GridLength(15,GridUnitType.Star)});
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(70, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(15, GridUnitType.Star) });
            grid.Children.Add(us, 1, 1);
            grid.Children.Add(pa, 1, 2);
            grid.Children.Add(btnlog, 1, 3);
            grid.Children.Add(restPas, 1, 4);
            grid.Children.Add(btncre, 1, 5);
            btncre.Clicked+=btncre_click;
            restPas.Clicked += res_click;

            Content = grid;//se entrega grid para que sea visualizado
        }
        async void res_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new respas());
        }
        async void btncre_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reg());
        }
    }
}

