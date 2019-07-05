using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XamarinNativeTrainingPOC.Models
{
    public class CanadaCountryData
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "rows")]
        public List<Row> CountryData { get; set; }
    }
}

public class Row
{
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }
    [JsonProperty(PropertyName = "imageHref")]
    public string imageUri { get; set; }
}

