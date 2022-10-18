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
    public partial class LoginUi : ContentPage
    {
        public LoginUi()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtuser.Text=="12" && txtpass.Text == "asd")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("error", "usuario o contraseña incorrecta", "ok");
            }
        }
    }
}