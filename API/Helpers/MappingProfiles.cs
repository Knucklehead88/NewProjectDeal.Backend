using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
            CreateMap<Core.Entities.Identity.Address, AddressDto>().ReverseMap();
            CreateMap<CustomerBasketDto, CustomerBasket>();
            CreateMap<BasketItemDto, BasketItem>();
            CreateMap<AddressDto, Core.Entities.OrderAggregate.Address>();
            CreateMap<Order, OrderToReturnDto>()
                .ForMember(d => d.DeliveryMethod, o => o.MapFrom(s => s.DeliveryMethod.ShortName))
                .ForMember(d => d.ShippingPrice, o => o.MapFrom(s => s.DeliveryMethod.Price));
            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(d => d.ProductId, o => o.MapFrom(s => s.ItemOrdered.ProductItemId))
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.ItemOrdered.ProductName))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => s.ItemOrdered.PictureUrl))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<OrderItemUrlResolver>());

            CreateMap<PersonalInfo, PersonalInfoDto>()
                .ForMember(a => a.Locations, opt => opt.Ignore());

            CreateMap<PersonalInfoDto, PersonalInfo>()
                .ForMember(a => a.Locations, opt => opt.Ignore());

            CreateMap<LocationDto, Location>()
                .ForMember(a => a.PersonalInfo, opt => opt.Ignore())
                //.ForMember(a => a.PersonalInfoId, opt => opt.Ignore())
                .ForMember(a => a.BusinessInfo, opt => opt.Ignore())
                //.ForMember(a => a.BusinessInfoId, opt => opt.Ignore())
                .ForMember(a => a.Id, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ExternalAuthDto, ExternalAuth>().ReverseMap();
            CreateMap<BusinessInfoDto, BusinessInfo>()
                .ForMember(a => a.Trades, opt => opt.Ignore())
                .ForMember(a => a.SpokenLanguages, opt => opt.Ignore())
                .ForMember(a => a.Locations, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<BusinessInfo, ResponseBusinessInfoDto>()
                .ForMember(a => a.Trades, opt => opt.Ignore())
                .ForMember(a => a.SpokenLanguages, opt => opt.Ignore())
                .ForMember(a => a.Locations, opt => opt.Ignore());


            CreateMap<ResponseBusinessInfoDto, BusinessInfo>()
                .ForMember(a => a.Trades, opt => opt.Ignore())
                .ForMember(a => a.SpokenLanguages, opt => opt.Ignore());

            CreateMap<Trade, TradeDto>()
                .ReverseMap();
            CreateMap<Trade, ResponseTradeDto>()
                .ReverseMap();
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<Language, ResponseLanguageDto>().ReverseMap();
                .ReverseMap();
            CreateMap<Trade, TradeDto>().ReverseMap();

            CreateMap<SendToEmail, SendToEmailDto>()
                .ReverseMap();

        }
    }
}