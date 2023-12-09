using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        CreateMap<Order, OrderDto>()
         .ForMember(o => o.Id, m => m.MapFrom(s => s.OrderId));

        CreateMap<OnlineOrder, OnlineOrderDto>()
          .IncludeBase<Order, OrderDto>();

        CreateMap<MailOrder, MailOrderDto>()
          .IncludeBase<Order, OrderDto>();
    }
}

// How it was done in 4.x - as of 5.0 this is obsolete:
// public class OrganizationProfile : Profile
// {
//     protected override void Configure()
//     {
//         CreateMap<Foo, FooDto>();
//     }
// }