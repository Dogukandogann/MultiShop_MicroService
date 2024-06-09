using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
using MultiShop.WebUı.Services.CatalogServices.CommentServices;
using Newtonsoft.Json;

namespace MultiShop.WebUı.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailCommentComponentPartial :ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ProductDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values = await _commentService.CommentListByProductId(id);
            return View(values);
            
        }
    }
}
