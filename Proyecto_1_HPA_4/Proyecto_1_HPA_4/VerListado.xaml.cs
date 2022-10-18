using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1_HPA_4.modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerListado : ContentPage
    {
        public VerListado()
        {
            ObservableCollection<Estudiante> estudiantes = new ObservableCollection<Estudiante>
            {
                new Estudiante
                {
                    Nombre="Pepe",
                    Cedula="1-1234-123123",
                    Fecha=DateTime.Now.ToString()
                }
            };
            InitializeComponent();
            var listView = new ListView();
            listView.ItemsSource = estudiantes;
        }
    }
}