using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrwlApi.Core.Enums;
using CrwlApi.Core.Types.Dto.Requests;
using RestEase;

namespace CrwlApi.Core.Dto
{
    /// <summary>
    /// Advert type from crwl
    /// </summary>
    public class AdvertDto: BaseApiDto //, IAdvertDto
    {
        /// <summary>
        /// Region number collection
        /// Attention, if the region number is not indicated, the result will contain ads throughout Russia
        /// </summary>
        [Query("region")]
        public List<RegionNumber> Regions { get; set; }
        
        /// <summary>
        /// For how many last hours is the result required
        /// </summary>
        [Query("last")]
        public int LastHours { get; set; }
        
        /// <summary>
        /// Sources collection
        /// What source do you need data from different platforms
        /// </summary>
        // todo: need to rework enum to string format
        [Query("source")]
        public List<string> Source { get; set; }
        
        /// <summary>
        /// Date range for which data is needed. Min Date
        /// </summary>
        [Query("min_date")]
        public DateTime MinDate { get; set; }

        /// <summary>
        /// Date range for which data is needed. Max Date
        /// </summary>
        [Query("max_date")]
        public DateTime MaxDate { get; set; }

        /// <summary>
        /// Maximum number of ads with one phone
        /// </summary>
        [Query("phone_find")]
        public int PhoneFind { get; set; }
        
        /// <summary>
        /// Min year cars yyyy format
        /// </summary>
        [Query("min_year")]
        public int MinYear { get; set; }

        /// <summary>
        /// Max year cars yyyy format
        /// </summary>
        [Query("max_year")]
        public int MaxYear { get; set; }

        /// <summary>
        /// The minimal price of a car
        /// </summary>
        [Query("min_price")]
        public decimal MinPrice { get; set; }

        /// <summary>
        /// The maximum price of a car
        /// </summary>
        [Query("max_price")]
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// Vehicle condition: 1 - Whole, 2 - Broken
        /// </summary>
        [Query("condition")]
        public CarCondition CarCondition { get; set; }

        /// <summary>
        /// Vehicle type: 1 - cars, 2 - light commercial, 3 - trucks and special equipment
        /// </summary>
        [Query("car")]
        public CarBodyType CarType { get; set; }
        
        /// <summary>
        /// There is only the 3rd type of car (used in conjunction with car = 3) and it can be equal to:
        /// crane - Truck cranes
        /// bulldozers - Bulldozers
        /// autoloader - Forklifts
        /// dredge - Excavators
        /// agricultural - Agricultural
        /// municipal - Municipal
        /// crane_hydraulics - Self Loaders
        /// construction - Construction
        /// artic - Tractor Units
        /// drags - Trailers
        /// trucks - Trucks
        /// bus - Buses
        /// swapbody - changed body
        /// </summary>
        // todo: need to add values to constant dictionary
        [Query("type")]
        public int TruckType { get; set; }

        /// <summary>
        /// New or Used car: true - new, false - all the rest (Default: all)
        /// </summary>
        [Query("new")]
        public bool IsNewCar { get; set; }

        /// <summary>
        /// Limit ads
        /// </summary>
        [Query("limit")]
        public int LimitAds { get; set; }

        public Task<string> GetAdvertsAsync()
        {
            throw new NotImplementedException();
        }
    }
}