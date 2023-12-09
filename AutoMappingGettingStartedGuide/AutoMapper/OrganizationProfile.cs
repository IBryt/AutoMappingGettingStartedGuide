using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        CreateMap<BaseEntity, BaseDto>()
            .Include<DerivedEntity, DerivedDto>()
            .ForMember(dest => dest.SomeMember, opt => opt.MapFrom(src => src.OtherMember));

        CreateMap<DerivedEntity, DerivedDto>();
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