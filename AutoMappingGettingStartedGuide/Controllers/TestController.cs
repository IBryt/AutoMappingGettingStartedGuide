using AutoMapper;
using AutoMappingGettingStartedGuide.Models;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System.Dynamic;


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
        var source = new Source<int> { Value = 10 };

        var dest = _mapper.Map<Source<int>, Destination<int>>(source);

        dest.Value.ShouldBeEquivalentTo(10);

        return Content("Hello, World!");
    }
}
