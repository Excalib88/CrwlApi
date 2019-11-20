using CrwlApi.Core.Enums;

namespace CrwlApi.Core.Dto
{
    /// <summary>
    /// Getting the average car price
    /// </summary>
    public class AverageCarPriceDto: BaseApiDto
    {
        public string Brand { get; set; }
     
        public string Model { get; set; }
        
        public int Year { get; set; }
        
        public RegionNumber Region { get; set; }
    }
}