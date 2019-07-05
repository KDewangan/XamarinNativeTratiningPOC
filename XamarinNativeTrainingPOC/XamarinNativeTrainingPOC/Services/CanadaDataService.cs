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
        IEnumerable<CanadaCountryData> CountryDataList;
        HttpClient httpClient;
        public CanadaDataService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri($"{App.BackendUrl}/");
            CountryDataList = new List<CanadaCountryData>();
        }

        public async Task<IEnumerable<CanadaCountryData>> GetCanadaData()
        {
            //if (CrossConnectivity.Current.IsConnected)
            //{
                var json = await httpClient.GetStringAsync($"/s/2iodh4vg0eortkl/facts.json");
            CountryDataList = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<CanadaCountryData>>(json));
            //}

            return CountryDataList;
        }
    }
}
