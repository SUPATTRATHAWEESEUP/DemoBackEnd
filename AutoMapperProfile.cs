using AutoMapper;
using DemoStandardProject.Models;
using DemoStandardProject.DTOs;
using System.Collections.Generic;
using DemoStandardProject.Models.Sales;

namespace DemoStandardProject
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<ProductGroup, ProductGroupDto>();
            CreateMap<ProductGroup, GetProductGroupName>();
            CreateMap<AddProductGroupDto, ProductGroup>();
            CreateMap<Product, ProductDto>();
            CreateMap<AddProductDto, Product>();
            CreateMap<Promotions, GetPromotion>();
            // .ForMember(x => x.ProductGroupId, x => x.MapFrom(x => x.ProductGroupId))
            //  .ForMember(x => x.PromotionId, x => x.MapFrom(x => x.PromotionId));
        }



    }
}