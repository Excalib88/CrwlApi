using CrwlApi.Core.Enums;
using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrwlApi.Core.Types.Dto.Requests
{
    public interface IAdvertRequest: IAdvertDto
    {
        [Get("latest/get_ads/")]
        Task<string> GetAdvertsAsync();
    }

    public interface IAdvertDto
    {
        [Query("api_key")]
        string ApiKey { get; set; }

        /// <summary>
        /// Region number collection
        /// Attention, if the region number is not indicated, the result will contain ads throughout Russia
        /// </summary>
        [Query("region")]
        string Regions { get; set; }

        /// <summary>
        /// For how many last hours is the result required
        /// </summary>
        [Query("last")]
        int? LastHours { get; set; }

        /// <summary>
        /// Limit ads
        /// </summary>
        [Query("limit")]
        int? LimitAds { get; set; }

        /// <summary>
        /// Vehicle type: 1 - cars, 2 - light commercial, 3 - trucks and special equipment
        /// </summary>
        // todo: Api does not return values ​​of type 2 and 3 
        //[Query("car")]
        //int CarType { get; set; }  

        #region Unused properties
        ///// <summary>
        ///// Sources collection
        ///// What source do you need data from different platforms
        ///// </summary>
        //// todo: need to rework enum to string format
        //[Query("source")]
        //string Source { get; set; }

        ///// <summary>
        ///// Date range for which data is needed. Min Date
        ///// </summary>
        //[Query("min_date")]
        //string MinDate { get; set; }

        ///// <summary>
        ///// Date range for which data is needed. Max Date
        ///// </summary>
        //[Query("max_date")]
        //string MaxDate { get; set; }

        ///// <summary>
        ///// Maximum number of ads with one phone
        ///// </summary>
        //[Query("phone_find")]
        //string PhoneFind { get; set; }

        ///// <summary>
        ///// Min year cars yyyy format
        ///// </summary>
        //[Query("min_year")]
        //string MinYear { get; set; }

        ///// <summary>
        ///// Max year cars yyyy format
        ///// </summary>
        //[Query("max_year")]
        //string MaxYear { get; set; }

        ///// <summary>
        ///// The minimal price of a car
        ///// </summary>
        //[Query("min_price")]
        //string MinPrice { get; set; }

        ///// <summary>
        ///// The maximum price of a car
        ///// </summary>
        //[Query("max_price")]
        //string MaxPrice { get; set; }

        ///// <summary>
        ///// Vehicle condition: 1 - Whole, 2 - Broken
        ///// </summary>
        //[Query("condition")]
        //string CarCondition { get; set; }

        ///// <summary>
        ///// There is only the 3rd type of car (used in conjunction with car = 3) and it can be equal to:
        ///// crane - Truck cranes
        ///// bulldozers - Bulldozers
        ///// autoloader - Forklifts
        ///// dredge - Excavators
        ///// agricultural - Agricultural
        ///// municipal - Municipal
        ///// crane_hydraulics - Self Loaders
        ///// construction - Construction
        ///// artic - Tractor Units
        ///// drags - Trailers
        ///// trucks - Trucks
        ///// bus - Buses
        ///// swapbody - changed body
        ///// </summary>
        //// todo: need to add values to constant dictionary
        //[Query("type")]
        //string TruckType { get; set; }

        ///// <summary>
        ///// New or Used car: true - new, false - all the rest (Default: all)
        ///// </summary>
        //[Query("new")]
        //string IsNewCar { get; set; }

        #endregion
    }
}
