using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAspNet.Services;
using XamarinAspNet.ViewModel;

namespace XamarinAspNet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetAllWeatherForecastsAsync();
            this.BindingContext = new TesteViewModel();
        }

        private async void GetAllWeatherForecastsAsync()
        {
            var service = new WeatherForecastService();
            var all = await service.GetAll();
            listaItens.ItemsSource = all;
        }

        private async void BTNSubmit_Clicked(object sender, EventArgs e)
        {
            var service = new WeatherForecastService();
            var response = await service.InsertTest(new PrimeiroProjeto.Models.Teste { Name = TXTName.Text, Age = Int32.Parse(TXTIdade.Text)});
            await DisplayAlert("Resposta", response, "Confirmar");
        }
    }
}
