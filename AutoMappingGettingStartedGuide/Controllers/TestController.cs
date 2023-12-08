using AutoMapper;
using AutoMappingGettingStartedGuide.Models;
using Microsoft.AspNetCore.Mvc;

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
        var source = new OuterSource
        {
            Value = 5,
            Inner = new InnerSource { OtherValue = 15 }
        };

        var dest = _mapper.Map<OuterSource, OuterDest>(source);
        var typeOuterDest = dest.GetType() == typeof(OuterDest);
        var typeInnerrDest = dest.Inner.GetType()== typeof(InnerDest) ;

        return Content("Hello, World!");
    }
}
