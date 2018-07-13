using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToyotaAuditoriaImagen.Views
{
    public partial class RecuperarClavePage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        public RecuperarClavePage()
        {
            InitializeComponent();
        }
    }
}
