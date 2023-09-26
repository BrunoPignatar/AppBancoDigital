using AppBancoDigital.Model;
using AppBancoDigital.View.Pagina_inicial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilCorrentista : ContentPage
    {
        public PerfilCorrentista()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            lblnome.Text = "@" + App.DadosCorrentista.Nome;
            lblCPF.Text = "" + App.DadosCorrentista.CPF;
            lbldatanasc.Text = "" + App.DadosCorrentista.Data_nasc;
           
        }

        private async void addfoto_Clicked(object sender, EventArgs e)
        {
            try
            {
                string nome;

                nome = App.DadosCorrentista.Nome;


              var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Selecione uma Imagem"
                });

              if (result != null) 
                {
                    Correntista a = new Correntista
                    {
                        ImagemEnviada = ImageSource.FromFile(result.FullPath),
                        Nome = nome,
                    };
                    App.DadosCorrentista = a;
                }
                App.Current.MainPage = new NavigationPage(new View.Home());


            }
            catch (Exception ex) 
            {
                DisplayAlert("Erro", "Ocorreu um erro ao enviar a imagem!\nTente Novamente.", "OK");
            }

            
        }

        private void Button_Clicked(object sender, EventArgs e)
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
    }
}