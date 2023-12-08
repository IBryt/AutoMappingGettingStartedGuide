using AutoMapper;
using AutoMappingGettingStartedGuide.Models;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        //mapping with error
        //CreateMap<Source, Destination>(); 

        CreateMap<Source, Destination>();

        CreateMap<CalendarEvent, CalendarEventForm>()
            .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.Date.Date))
            .ForMember(dest => dest.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
            .ForMember(dest => dest.EventMinute, opt => opt.MapFrom(src => src.Date.Minute));

        CreateMap<OuterSource, OuterDest>();

        CreateMap<InnerSource, InnerDest>();

        CreateMap<ParentSource, ParentDestination>()
            .Include<ChildSource, ChildDestination>();

        CreateMap<ChildSource, ChildDestination>();
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