using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinAspNet.Models;
using XamarinAspNet.Settings;

namespace XamarinAspNet.Services
{
    public class WeatherForecastService
    {
        private string APIURL;
        public WeatherForecastService()
        {
            APIURL = ApiSettings.APIURL;
        }

        public async Task<List<WeatherForecastModel>> GetAll()
        {
            var cliente = new HttpClient();
            var responseBody = await cliente.GetAsync($"{APIURL}/WeatherForecast");
            var content = await responseBody.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<WeatherForecastModel>>(content);
            return json;
        }
    }
}
