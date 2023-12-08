using AutoMapper;
using AutoMappingGettingStartedGuide.Models;
using Microsoft.AspNetCore.Mvc;
using Shouldly;


namespace AutoMappingGettingStartedGuide.Controllers;
public class TestController : Controller
{
    private readonly IMapper _mapper;

    public TestController(IMapper mapper)
    {
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult HelloWorld()
    {
        dynamic sources = null;
        //var sources = new[]
        //{
        //    new Source { Value = 5 },
        //    new Source { Value = 6 },
        //    new Source { Value = 7 }
        //};

        IEnumerable<Destination> ienumerableDest = _mapper.Map<Source[], IEnumerable<Destination>>(sources);
        ICollection<Destination> icollectionDest = _mapper.Map<Source[], ICollection<Destination>>(sources);
        IList<Destination> ilistDest = _mapper.Map<Source[], IList<Destination>>(sources);
        List<Destination> listDest = _mapper.Map<Source[], List<Destination>>(sources);
        Destination[] arrayDest = _mapper.Map<Source[], Destination[]>(sources);

        var sources2 = new[]
        {
            new ParentSource(),
            new ChildSource(),
            new ParentSource()
        };

        var destinations = _mapper.Map<ParentSource[], ParentDestination[]>(sources2);

        destinations[0].ShouldBeOfType<ParentDestination>();
        destinations[1].ShouldBeOfType<ChildDestination>();
        destinations[2].ShouldBeOfType<ParentDestination>();

        return Content("Hello, World!");
    }
}
