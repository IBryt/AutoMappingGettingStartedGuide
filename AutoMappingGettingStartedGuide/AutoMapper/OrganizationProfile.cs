using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        //CreateMap<Order, OrderDto>()
        //  .ForMember(d => d.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
        //  .ReverseMap();

        CreateMap<Order, OrderDto>()
          .ForMember(d => d.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
          .ReverseMap()
          .ForPath(s => s.Customer.Name, opt => opt.MapFrom(src => src.CustomerName));
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