﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}