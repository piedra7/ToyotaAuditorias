using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToyotaAuditoriaImagen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage 
    {
        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
           
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            AuditoriaPage auditoria = new AuditoriaPage();
            await Navigation.PushModalAsync(auditoria);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}