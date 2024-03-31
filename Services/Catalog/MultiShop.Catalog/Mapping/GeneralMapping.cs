using AutoMapper;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,GetByIdProductDto>().ReverseMap();

            CreateMap<Product, ResultProductDetailDto>().ReverseMap();
            CreateMap<Product, CreateProductDetailDto>().ReverseMap();
            CreateMap<Product, UpdateProductDetailDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<Product, ResultProductImageDto>().ReverseMap();
            CreateMap<Product, CreateProductImageDto>().ReverseMap();
            CreateMap<Product, UpdateProductImageDto>().ReverseMap();
            CreateMap<Product, GetByIdProductImageDto>().ReverseMap();
        }
    }
}
