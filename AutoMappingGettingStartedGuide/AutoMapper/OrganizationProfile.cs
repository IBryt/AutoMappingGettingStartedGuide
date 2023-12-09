using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        CreateMap<Order, OrderDto>()
         .Include<OnlineOrder, OnlineOrderDto>()
         .Include<MailOrder, MailOrderDto>();

        CreateMap<OnlineOrder, OnlineOrderDto>();
        
        CreateMap<MailOrder, MailOrderDto>();
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