using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
using Newtonsoft.Json;

namespace MultiShop.WebUı.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailCommentComponentPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductDetailCommentComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7273/api/Comments/CommentListByProductId?id="+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
