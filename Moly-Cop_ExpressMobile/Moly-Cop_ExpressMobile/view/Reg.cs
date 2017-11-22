using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view
{
    public class Reg : ContentPage
    {
        public Reg()
        {
            /* agregar campos para registro, id,nombre,correo,empresa
             * contraseña fecha registro,*/
            /*agregar un control de inicio cada vez que el usuario salga de la aplicacion se cierre
             * al iniciar la aplicacion agregar un control que registra usuario fecha y hora*/
            /*especificacion de botones y de los tamaños del grid para odenar los elementos*/
            var btnreg = new Button { Text = "Register"  };
            var us = new Entry { Placeholder = "example@example.com" };
            var no = new Entry { Placeholder = "Name" };
            var pa = new Entry { Placeholder = "password" };
            var em = new Entry { Placeholder = "Company" };
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition{Height=new GridLength(10,GridUnitType.Star)});
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition{Width =new GridLength(15,GridUnitType.Star)});
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(70, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(15, GridUnitType.Star) });
            grid.Children.Add(no,1,1);
            grid.Children.Add(us, 1, 2);
            grid.Children.Add(pa, 1, 3);
            grid.Children.Add(em, 1, 4);
            grid.Children.Add(btnreg, 1, 5);

            Content = grid;//se entrega grid para que sea visualizado
        }

    }
}

