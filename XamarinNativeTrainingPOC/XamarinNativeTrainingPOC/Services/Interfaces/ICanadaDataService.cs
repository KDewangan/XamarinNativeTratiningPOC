using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinNativeTrainingPOC.Models;

namespace XamarinNativeTrainingPOC.Services.Interfaces
{
    public interface ICanadaDataService<T>
    {
        Task<T> GetCanadaData();
         
    }
}
