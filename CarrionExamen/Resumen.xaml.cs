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
    public partial class Resumen : ContentPage
    {
        public Resumen(string Estudiante, double valor, string user)
        {
            InitializeComponent();
            usuarioConectado.Text = user;
            estudiante.Text = Estudiante;
            vTotal.Text = Convert.ToString(valor);
        }
    }
}