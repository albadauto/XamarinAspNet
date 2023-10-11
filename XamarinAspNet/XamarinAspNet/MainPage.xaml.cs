using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAspNet.Services;

namespace XamarinAspNet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetAllWeatherForecastsAsync();
        }

        private async void GetAllWeatherForecastsAsync()
        {
            var service = new WeatherForecastService();
            var all = await service.GetAll();
            listaItens.ItemsSource = all;
        }
    }
}
