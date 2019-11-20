using System;
using CrwlApi.Core.Enums;
using Newtonsoft.Json;

namespace CrwlApi.Core.Types.Dto.Responses
{
    //todo: need to modify types
    public class AdvertResponse : ResponseBase
    {
        [JsonProperty("dt")]
        public DateTime Date { get; set; }

        public string Region { get; set; }

        public string Url { get; set; }
        
        [JsonProperty("marka")]
        public string Make { get; set; }
        
        public string Model { get; set; }

        [JsonProperty("model_2")]
        public string ModelAlternative { get; set; }
        
        public string Color { get; set; }

        public string Body { get; set; }
        
        public string Transmission { get; set; }
        
        [JsonProperty("engine")]
        public string EngineType { get; set; }
        
        [JsonProperty("enginevol")]
        public string EngineVolume { get; set; }
        
        /// <summary>
        /// Битая не битая
        /// </summary>
        public string Condition { get; set; }
        
        /// <summary>
        /// Привод
        /// </summary>
        public string Drive { get; set; }
        
        /// <summary>
        /// Пробег
        /// </summary>
        public string Run { get; set; }

        [JsonProperty("run_ed")]
        public string RunUnit { get; set; }
        
        public string Year { get; set; }
        
        public string Modification { get; set; }
        
        public string Phone { get; set; }
        
        [JsonProperty("fio")]
        public string FullName { get; set; }
        
        public string Address { get; set; }
        
        public string Price { get; set; }
       
        /// <summary>
        /// Количество просмотров
        /// </summary>
        public string Viewed { get; set; }
        
        [JsonProperty("pts_owner")]
        public string PtsOwners { get; set; }
        
        [JsonProperty("info")]
        public string Description { get; set; }
        
        public string Horse { get; set; }
        
        public string Vin { get; set; }
        
        [JsonProperty("e_mail")]
        public string Mail { get; set; }
        
        public string Company { get; set; }
        
        public string Fuel { get; set; }
        
        public string Photo { get; set; }
        
        public double? Latitude { get; set; }
        
        public double? Longitude { get; set; }
        
        /// <summary>
        /// руль левый правый
        /// </summary>
        public string Wheel { get; set; }
        
        /// <summary>
        /// комплектация
        /// </summary>
        [JsonProperty("complect")]
        public string Equipment { get; set; }
        
        /// <summary>
        /// Количество объявлений по номеру телефона
        /// </summary>
        [JsonProperty("phone_find")]
        public string AdsAmountByPhone { get; set; }

        public string Metro { get; set; }
        
        [JsonProperty("region_Id")]
        public RegionNumber RegionNumber { get; set; }
        
        [JsonProperty("average_price")]
        public string AveragePrice { get; set; }
        
        [JsonProperty("difference_price")]
        public string DifferencePrice { get; set; }
        
        public string Source { get; set; }
        
        public string Fast { get; set; }
        
        [JsonProperty("protected")]
        public string Protected { get; set; }
        
        [JsonProperty("new")]
        public string New { get; set; }
        
        public string Gender { get; set; }
    }
}