using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToyotaAuditoriaImagen.Views
{
    public partial class AuditoriaPage : ContentPage
    {
        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            IncidenciasPage incidenciasAuditoria = new IncidenciasPage();
            await Navigation.PushModalAsync(incidenciasAuditoria);
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public AuditoriaPage()
        {
            InitializeComponent();
        }
    }
}
