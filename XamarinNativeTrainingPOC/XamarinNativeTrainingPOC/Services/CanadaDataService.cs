using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinNativeTrainingPOC.Models;
using XamarinNativeTrainingPOC.Services.Interfaces;

namespace XamarinNativeTrainingPOC.Services
{
    public class CanadaDataService: ICanadaDataService<CanadaCountryData>
    {
        
        HttpClient httpClient;
        public CanadaDataService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri($"{App.BackendUrl}/");
        }  

        public async Task<CanadaCountryData> GetCanadaData()
        {
          CanadaCountryData CountryData = new CanadaCountryData();
            try
            {
                var json = await httpClient.GetStringAsync($"/s/2iodh4vg0eortkl/facts.json");
                CountryData = await Task.Run(() => JsonConvert.DeserializeObject<CanadaCountryData>(json));
            }
            catch(Exception ex)
            {

            }

            return CountryData;
        }
    }
}
