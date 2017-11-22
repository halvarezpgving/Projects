using System;

using Xamarin.Forms;

namespace MolyCop_ExpressMobile.view
{
    public class Login : ContentPage
    {
        public Login()
        {
            var btnlog = new Button { Text = "Log In" };
            var btncre = new Button { Text = "Create Account" };
            var us = new Entry { Placeholder = "example@example.com" };
            var pa = new Entry { Placeholder = "password" };
            var restPas = new Label { Text = "Forgot Your Password" };

            Content = new StackLayout
            {


                Children = {
                    us,pa,btnlog,restPas,btncre
 
                }
            };
        }
    }
}

