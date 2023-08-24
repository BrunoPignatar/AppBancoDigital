using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            btn_Pix.Source = ImageSource.FromResource("AppBancoDigital.Assets.pix.png");
            btn_QrCode.Source = ImageSource.FromResource("AppBancoDigital.Assets.QrCode.png");
            btn_poupanca.Source = ImageSource.FromResource("AppBancoDigital.Assets.Porco.png");
        }

        private void Pix_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_QrCode_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_poupanca_Clicked(object sender, EventArgs e)
        {

        }
    }
}