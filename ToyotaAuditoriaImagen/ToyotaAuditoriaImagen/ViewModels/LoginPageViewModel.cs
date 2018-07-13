using System.Windows.Input;
using Xamarin.Forms;
using ToyotaAuditoriaImagen.Views;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ToyotaAuditoriaImagen.ViewModels
{
    public class LoginPageViewModel:BaseViewModel
    {
        #region Commands
        public INavigation Navigation { get; set; }
        public ICommand LoginCommand { get; set; }
        #endregion

        #region Properties
    //    private User _user = new User();

  /*      public User User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }*/

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        #endregion

        #region Constructor
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () => await Login());

        }

        #endregion

        #region Metodos
        async Task Login() => Application.Current.MainPage = new AppMenuPage();/*     IsBusy = true;
            Title = string.Empty;
            try
            {
                if (User.Email != null)
                {
                    if (User.Password != null)
                    {
                        if (User.Email == "osp@ttltech.com" && User.Password == "654321")
                        {
                            Settings.IsLoggedIn = true;

                            
                            Application.Current.Properties["userlogged"] = 1;
                        }
                        else
                        {
                            Message = "Usuario o contraseña incorrecta";
                        }
                        IsBusy = false;
                    }
                    else
                    {
                        IsBusy = false;
                        Message = "La contraseña es requerido";
                    }

                }
                else
                {
                    IsBusy = false;
                    Message = "El email es requerido";
                }

            }
            catch (Exception e)
            {
                IsBusy = false;
                await App.Current.MainPage.DisplayAlert("Error de conexión", e.Message, "Ok");
            }*/

        #endregion
    }
    }

