using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUı.Models;
using Newtonsoft.Json;

namespace MultiShop.RapidApiWebUı.Controllers
{
    public class DefaultController : Controller
    {
        public async Task<IActionResult> WeatherDetail()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://the-weather-api.p.rapidapi.com/api/weather/Istanbul"),
                Headers =
    {
                { "x-rapidapi-key", "a8c1779fe2msh0bc9ca135007d6ap166f35jsn5a1f1a9b8a42" },
                { "x-rapidapi-host", "the-weather-api.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel.Rootobject>(body);

                return View(values);
            }
        }
        public async Task<IActionResult> Exchange()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "a8c1779fe2msh0bc9ca135007d6ap166f35jsn5a1f1a9b8a42");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "real-time-finance-data.p.rapidapi.com");

            var usdRequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=USD&language=en&to_symbol=TRY");
            var eurRequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=EUR&language=en&to_symbol=TRY");

            var usdTask = GetExchangeRateAsync(client, usdRequestUri);
            var eurTask = GetExchangeRateAsync(client, eurRequestUri);

            await Task.WhenAll(usdTask, eurTask);

            var usdValues = await usdTask;
            var eurValues = await eurTask;

            ViewBag.ExchangeUsd = usdValues.data.exchange_rate;
            ViewBag.PreviousUsd = usdValues.data.previous_close;
            ViewBag.ExchangeEur = eurValues.data.exchange_rate;
            ViewBag.PreviousEur = eurValues.data.previous_close;
            return View();
        }

        private async Task<CurrencyViewModel.Rootobject> GetExchangeRateAsync(HttpClient client, Uri requestUri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CurrencyViewModel.Rootobject>(body);
            }
        
        }
    }
}
