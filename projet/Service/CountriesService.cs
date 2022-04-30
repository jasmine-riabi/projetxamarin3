using Newtonsoft.Json;
using projet.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace projet.Service
{
    public static class CountriesService
    {
        private static readonly HttpClient client = CrearHttpClient();

        private static HttpClient CrearHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        public async static Task<List<Country>> GetCountriesEurope()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.com/v3.1/region/europe");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

        public async static Task<List<Country>> GetCountriesAsia()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.com/v3.1/region/asia");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

        public async static Task<List<Country>> GetCountriesAfrique()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.com/v3.1/region/africa");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

        public async static Task<List<Country>> GetCountriesAmerique()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.com/v3.1/region/americas");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

        public async static Task<List<Country>> GetCountriesOceanie()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.com/v3.1/region/oceania");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

        public async static Task<List<Country>> GetCountriesAntartic()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.com/v3.1/region/antarctic");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

    }
}
