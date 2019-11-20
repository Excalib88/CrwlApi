using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrwlApi.Core.Dto;
using CrwlApi.Core.Types.Dto.Requests;
using CrwlApi.Core.Types.Dto.Responses;
using Newtonsoft.Json;
using RestEase;

namespace CrwlApi.Core.Types
{
    public class CrwlClient
    {
        private const string BaseUrl = "http://crwl.ru/api/rest/";
        private readonly string _apiKey;

        public CrwlClient(string apiKey)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        public async Task<List<AdvertResponse>> GetAdverts(AdvertDto advertDto)
        {
            var advertRequest = RestClient.For<IAdvertRequest>(BaseUrl);

            advertRequest.ApiKey = _apiKey;
            //advertRequest.LastHours = advertDto.LastHours;
            advertRequest.LimitAds = 10000;

            var response = await advertRequest.GetAdvertsAsync();

            var result = JsonConvert.DeserializeObject<List<AdvertResponse>>(response);

            return result;
        }
    }
}