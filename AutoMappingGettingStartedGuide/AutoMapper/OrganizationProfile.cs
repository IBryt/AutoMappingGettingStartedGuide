using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        CreateMap<Order, OrderDto>()
          .Include<OnlineOrder, OrderDto>()
          .Include<MailOrder, OrderDto>()
          .ForMember(o => o.Referrer, m => m.Ignore());

        CreateMap<OnlineOrder, OrderDto>();
        CreateMap<MailOrder, OrderDto>();
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