using AppBancoDigital.Model;
using AppBancoDigital.View.Pagina_inicial;
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

            btn_scanner.Source = ImageSource.FromResource("AppBancoDigital.Assets.scanner.png");
            btn_Pix.Source = ImageSource.FromResource("AppBancoDigital.Assets.pix.png");
            btn_QrCode.Source = ImageSource.FromResource("AppBancoDigital.Assets.QrCode.png");
            userName.Text = "Olá, " + App.DadosCorrentista.Nome;

            // lblsaldo.Text = App.DadosConta.ToString();

            if (App.DadosCorrentista.ImagemEnviada != null)
            {
                imagem_de_perfil.Source = App.DadosCorrentista.ImagemEnviada;
               
            }
        }

        private void Pix_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new Pix());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private void btn_QrCode_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new QrCode());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private void imagem_de_perfil_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new PerfilCorrentista());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "OK");
            } 
        }

        private void btn_scanner_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new Scanner());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "OK");
            }
        }
    }
}