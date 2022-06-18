﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txtnumero1.Text) + Double.Parse(txtnumero2.Text);
                await Navigation.PushAsync(new resultado(total.ToString()));
            }
            catch
            {
               await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
          
        }

        private async void btnRestar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txtnumero1.Text) - Double.Parse(txtnumero2.Text);
                await Navigation.PushAsync(new resultado(total.ToString()));
            }
           

              catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
        }

        private async void btnDividir_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txtnumero1.Text) / Double.Parse(txtnumero2.Text);
                await Navigation.PushAsync(new resultado(total.ToString()));
            }
            catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }


        }

        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txtnumero1.Text) * Double.Parse(txtnumero2.Text);
                await Navigation.PushAsync(new resultado(total.ToString()));
            }


             catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
        }
    }
}
