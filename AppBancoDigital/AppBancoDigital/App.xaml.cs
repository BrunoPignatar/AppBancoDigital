using AppBancoDigital.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancoDigital.View;
using AppBancoDigital.Model;

namespace AppBancoDigital
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        /**
         * Armazena os dados do Correntista após o login.
         */
        public static Correntista DadosCorrentista { get; set; } = new Correntista();
        public static Conta DadosConta { get; set; } = new Conta();

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
