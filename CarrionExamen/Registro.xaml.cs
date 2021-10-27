using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarrionExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {

        double valorMil = 1800.00;
        double valorM;
        double porcentaje5 = 90;
        string user;

        public Registro(string usuario)
        {
            InitializeComponent();
            usuarioConectado.Text = "Usuario conectado: " + usuario;
            user = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {

                double inicial = Convert.ToDouble(valorInicial.Text);
                double mensual = 0.00;

                if (inicial <= 0.00)
                {
                    DisplayAlert("Mensaje de alerta", "Valor inferior al permitido", "ok");
                }
                else 
                    if(inicial > 1800.00)
                {
                    DisplayAlert("Mensaje de alerta", "Valor superior al permitido", "ok");
                }
                    else
                        if(inicial == 1800.00)
                        {
                            mensual = 0;
                            valorMensual.Text = "No hay valor mensual";
                            valorM = mensual;
                        }
                        else
                        {
                            mensual = ((valorMil - inicial) / 3) + (porcentaje5 / 3);
                            valorMensual.Text = Convert.ToString(mensual);
                            valorM = mensual;
                        }
            }
            catch(Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string nombreEstudiante = nombreEst.Text;
                double total = 0.00;
                total = valorM * 3 + valorMil;
                await Navigation.PushAsync(new Resumen(nombreEstudiante, total, user));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje de alertar", ex.Message, "OK");
            }
                
        }
    }
}