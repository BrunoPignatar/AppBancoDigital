using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;

namespace AppBancoDigital.View.Pagina_inicial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QrCode : ContentPage
    {
        public QrCode()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string teste = "Chave de Transferência:" + App.DadosCorrentista.CPF;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            img_qr.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }
    }
}