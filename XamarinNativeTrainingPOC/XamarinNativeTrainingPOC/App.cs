using System;
using XamarinNativeTrainingPOC.Helpers;
using XamarinNativeTrainingPOC.Models;
using XamarinNativeTrainingPOC.Services;
using XamarinNativeTrainingPOC.Services.Interfaces;

namespace XamarinNativeTrainingPOC
{
    public class App
    {
        public static bool UseMockDataStore = false;
        public static string BackendUrl = "https://dl.dropboxusercontent.com";

        public static void Initialize()
        {
            //if(UseMockDataStore)
               // ServiceLocator.Instance.Register<ICanadaDataService<Item>, MockDataStore>();
            //else
             ServiceLocator.Instance.Register<ICanadaDataService<CanadaCountryData>, CanadaDataService>();
        }
    }
}
