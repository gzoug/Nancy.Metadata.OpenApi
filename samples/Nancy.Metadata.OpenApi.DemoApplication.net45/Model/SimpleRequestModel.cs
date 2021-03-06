﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infocode.Nancy.Metadata.OpenApi.DemoApplication.net45.Model
{
    public class SimpleRequestModel
    {
        [Required]
        public string Name { get; set; }

        [JsonProperty("array1")]
        public List<string> FirstArray { get; set; }

        [JsonProperty("array2")]
        public List<string> SecondArray { get; set; }
    }
}
