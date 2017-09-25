using System.Collections.Generic;
using Newtonsoft.Json;
using RavenR.Models;

namespace RavenR.Data.Seed
{
  public static class ProductSeed
  {
    public static List<Product> Product =>
      JsonConvert.DeserializeObject<List<Product>>(
        @"[{
              ""Name"": ""Razer Blade Stealth"",
              ""Price"": ""0.52""
            }, {
              ""Name"": ""Razer Blade Pro"",
              ""Price"": ""3.79""
            }, {
              ""Name"": ""Razer Blade"",
              ""Price"": ""7.99""
            }, {
              ""Name"": ""Razer Core"",
              ""Price"": ""7.99""
            }, {
              ""Name"": ""Razer Lancehead"",
              ""Price"": ""6.00""
            }, {
              ""Name"": ""Razer DeathAdder Elite"",
              ""Price"": ""4.00""
            }, {
              ""Name"": ""Razer Abyssus V2"",
              ""Price"": ""4.94""
            }, {
              ""Name"": ""Razer Naga Hex V2"",
              ""Price"": ""0.38""
            }, {
              ""Name"": ""Razer BlackWidow X Chroma Gunmetal Grey"",
              ""Price"": ""6.98""
            }, {
              ""Name"": ""Razer BlackWidow X Chroma Mercury White"",
              ""Price"": ""2.05""
            }, {
              ""Name"": ""Razer BlackWidow X Chroma"",
              ""Price"": ""4.24""
            }, {
              ""Name"": ""Razer BlackWidow Tournament Edition Chroma V2"",
              ""Price"": ""2.17""
            }, {
              ""Name"": ""Razer BlackWidow X Tournament Edition Chroma"",
              ""Price"": ""8.65""
            }, {
              ""Name"": ""Razer BlackWidow Ultimate"",
              ""Price"": ""2.09""
            }, {
              ""Name"": ""Razer BlackWidow X Ultimate"",
              ""Price"": ""7.99""
            }, {
              ""Name"": ""Razer BlackWidow X Tournament Edition"",
              ""Price"": ""8.20""
            }, {
              ""Name"": ""Razer Ornata Chroma"",
              ""Price"": ""0.17""
            }, {
              ""Name"": ""Razer Ornata"",
              ""Price"": ""1.92""
            }, {
              ""Name"": ""Razer Orbweaver Chroma"",
              ""Price"": ""9.39""
            }, {
              ""Name"": ""Razer Tartarus Chroma"",
              ""Price"": ""3.44""
            }, {
              ""Name"": ""Razer Turret"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Tiamat 2.2 V2"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer ManO'War 7.1"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Overwatch Razer ManO’War Tournament Edition"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Kraken 7.1 V2 Gunmetal Grey"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Kraken 7.1 V2 Mercury White"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Kraken 7.1 V2 Black"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Kraken Pro V2 Black"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Kraken Mobile"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Thresher Tournament Edition"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Hammerhead for iOS"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Hammerhead Pro V2"",
              ""Price"": ""3.60""
            }, {
              ""Name"": ""Razer Hammerhead V2"",
              ""Price"": ""3.60""
            }]");
  }
}
