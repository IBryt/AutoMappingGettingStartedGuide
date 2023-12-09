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
        dynamic foo = new MyDynamicObject();
        foo.Bar = 5;
        foo.Baz = 6;

        var result = _mapper.Map<Foo>(foo);


        dynamic foo2 = _mapper.Map<MyDynamicObject>(result);


        return Content("Hello, World!");
    }
}
