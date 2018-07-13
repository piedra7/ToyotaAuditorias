using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToyotaAuditoriaImagen.Views
{
    public partial class AppMenuPage : MasterDetailPage
    {
        public AppMenuPage()
        {
            InitializeComponent();
            MyMenu();
        }

        public void MyMenu()
        {
            Detail = new NavigationPage(new MainPage());
            List<Menu> menu = new List<Menu>
            {
                new Menu{ Page= new MainPage(),MenuTitle="Mis Auditorías Programadas", MenuDetail="Mi perfil",icon="audit.png"},
                new Menu{ Page= new MainPage(),MenuTitle="Mi Historial",   MenuDetail="Mensajes",icon="history.png"},
                new Menu{ Page= new PlanosPage(),MenuTitle="Planos Toyota",   MenuDetail="Contactos",icon="plans.png"},
                new Menu{ Page= new MainPage(),MenuTitle="Documentos Requisito Pre-Auditoría",   MenuDetail="Configuración",icon="documents.png"},
                new Menu{ Page= new MainPage(),MenuTitle="Mis Agencias",   MenuDetail="Configuración",icon="usersmenu.png"},
                new Menu{ Page= new MainPage(),MenuTitle="Auditorías en curso y terminadas",   MenuDetail="Configuración",icon="ongoing.png"},
                new Menu{ Page= new MainPage(),MenuTitle="Inbox",   MenuDetail="Configuración",icon="mailwhite.png"}

            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {           
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }

            public ImageSource icon
            {
                get;
                set;
            }

            public Page Page
            {
                get;
                set;
            }
        }
    }
}