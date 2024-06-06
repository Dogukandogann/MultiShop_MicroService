using MultiShop.DtoLayer.CatalogDtos.FeatureSliderDtos;
using Newtonsoft.Json;

namespace MultiShop.WebUı.Services.CatalogServices.SliderServices
{
    public class FeatureSliderService :IFeatureSliderService
    {
        private readonly HttpClient _httpClient;
        public FeatureSliderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateFeatureSliderAsync(CreateFeatureSliderDto createFeatureSliderDto)
        {
            await _httpClient.PostAsJsonAsync<CreateFeatureSliderDto>("featuresliders", createFeatureSliderDto);
        }
        public async Task DeleteFeatureSliderAsync(string id)
        {
            await _httpClient.DeleteAsync("featuresliders?id=" + id);
        }
        public async Task<UpdateFeatureSliderDto> GetByIdFeatureSliderAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("featuresliders/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateFeatureSliderDto>();
            return values;
        }
        public async Task<List<ResultFeatureSliderDto>> GetAllFeatureSliderAsync()
        {
            var responseMessage = await _httpClient.GetAsync("featuresliders");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultFeatureSliderDto>>(jsonData);
            return values;
        }
        public async Task UpdateFeatureSliderAsync(UpdateFeatureSliderDto updateFeatureSliderDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateFeatureSliderDto>("featuresliders", updateFeatureSliderDto);
        }

        public async Task<bool> FeatureSliderChageStatusToTrue(string id)
        {
            var responseMessage = await _httpClient.GetAsync("featuresliders/" + id);
            if (!responseMessage.IsSuccessStatusCode)
            {
                return false;
            }

            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateFeatureSliderDto>();
            values.Status = true;

            var updateResponse = await _httpClient.PutAsJsonAsync("featuresliders/" + id, values);
            return updateResponse.IsSuccessStatusCode;
        }

        public async Task<bool> FeatureSliderChageStatusToFalse(string id)
        {
            var responseMessage = await _httpClient.GetAsync("featuresliders/" + id);
            if (!responseMessage.IsSuccessStatusCode)
            {
                return false;
            }

            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateFeatureSliderDto>();
            values.Status = false;

            var updateResponse = await _httpClient.PutAsJsonAsync("featuresliders/" + id, values);
            return updateResponse.IsSuccessStatusCode;
        }
    }
}
