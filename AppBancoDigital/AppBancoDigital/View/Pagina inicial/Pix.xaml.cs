using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoDigital.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pagina_inicial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pix : ContentPage
    {
        public Pix()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Assets.back.png");
            lbl_minhaschaves.Text = "" + App.DadosCorrentista.CPF;
            btn_transferir.Source = ImageSource.FromResource("AppBancoDigital.Assets.trans.png");
            btn_pixcopiaecola.Source = ImageSource.FromResource("AppBancoDigital.Assets.copiaecola.png");
            btn_cobrarcompix.Source = ImageSource.FromResource("AppBancoDigital.Assets.cobrarcompix.png");
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new Home());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private void btn_transferir_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_pixcopiaecola_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_cobrarcompix_Clicked(object sender, EventArgs e)
        {

        }
    }
}