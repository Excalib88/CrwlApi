using CrwlApi.Core.Enums;

namespace CrwlApi.Core.Dto
{
    /// <summary>
    /// Receiving new adverts by region
    /// </summary>
    public class AdvertByRegionDto: BaseApiDto
    {
        public RegionNumber Region { get; set; }
    }
}