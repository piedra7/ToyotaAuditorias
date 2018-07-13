using System;
using System.Collections.Generic;
using ToyotaAuditoriaImagen.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToyotaAuditoriaImagen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new RecuperarClavePage();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new AppMenuPage();
        }

        LoginPageViewModel viewModel;

        public LoginPage()
        {
            
            InitializeComponent();
            BindingContext = viewModel = new LoginPageViewModel();

        }
    }
}
