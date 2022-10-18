using Proyecto_1_HPA_4.DB;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerListado2 : ContentPage
    {
        public VerListado2()
        {
            InitializeComponent();
            MyListView.ItemsSource = Estudianteinfo.Get();
        }
    }
}