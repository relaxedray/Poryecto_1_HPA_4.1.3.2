using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void Pasar_Lista(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PasarLista());
        }
        private void Ver_Listado(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerListado2());
        }


    }
}