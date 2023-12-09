using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        CreateMap<MyDynamicObject, Foo>()
            .ReverseMap();
   
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