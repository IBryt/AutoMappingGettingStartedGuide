using AutoMapper;

namespace AutoMappingGettingStartedGuide.AutoMapper;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        //CreateMap<Foo, FooDto>();
        // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
        Console.WriteLine("creating map");
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