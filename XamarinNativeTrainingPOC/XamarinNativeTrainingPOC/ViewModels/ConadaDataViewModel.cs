using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using XamarinNativeTrainingPOC.Helpers;
using XamarinNativeTrainingPOC.Models;
using XamarinNativeTrainingPOC.Services;
using XamarinNativeTrainingPOC.Services.Interfaces;

namespace XamarinNativeTrainingPOC.ViewModels
{
    public class ConadaDataViewModel:BaseViewModel
    {
        public CanadaCountryData Items { get; set; }
        public  Command LoadItemsCommand { get; set; }
        private readonly ICanadaDataService<CanadaCountryData> _canadaDataService;
        
        public ConadaDataViewModel()
        {
            try
            {
                 this._canadaDataService = ServiceLocator.Instance.Get<ICanadaDataService<CanadaCountryData>>()?? new CanadaDataService();
               // LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            }
            catch(Exception ex)
            {

            }
        }

        public async Task<CanadaCountryData> ExecuteLoadItemsCommand()
        {
            //if (IsBusy)
            //    return;

            //IsBusy = true;

            try
            {
                Items = await _canadaDataService.GetCanadaData();
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                
                //IsBusy = false;
            }
            return Items;
        }
    }
}
