using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToyotaAuditoriaImagen.Views
{
    public partial class IncidenciasPage : ContentPage
    {
        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await  DisplayAlert("Camara no encontrada", "No es posible abrir la camara del dispositivo", "Aceptar","Cerrar");

        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public IncidenciasPage()
        {
            InitializeComponent();
        }
    }
}
