using System;
using MolyCop_ExpressMobile.view;
using Xamarin.Forms;

namespace MolyCop_ExpressMobile
{
    
    public partial class Moly_Cop_ExpressMobilePage : ContentPage
    {
        public Moly_Cop_ExpressMobilePage()
        {
            InitializeComponent();

        }
        /* Definir dinamismo de pantalla principal botones en la extencion xaml se engrega botones y Logo.*/
        async void crac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reg());
        }

        async void logn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());

        }
    }
}
