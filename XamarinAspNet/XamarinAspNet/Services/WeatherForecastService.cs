using Newtonsoft.Json;
using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinAspNet.Models;
using XamarinAspNet.Settings;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task<string> InsertTest(Teste values)
        {
            var cliente = new HttpClient();
            var response = await cliente.PostAsync($"{APIURL}/WeatherForecast/Teste", new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json"));
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
