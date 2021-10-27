using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarrionExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                if (usuario.Equals("estudiante2021") && clave.Equals("uisrael2021"))
                {
                    await Navigation.PushAsync(new Registro(usuario));

                }
                else

                    await DisplayAlert("Mensaje de alerta", "Usuario y/o clave incorrectos", "ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de alertar", ex.Message, "ok");
            }
            
        }
    }
}
