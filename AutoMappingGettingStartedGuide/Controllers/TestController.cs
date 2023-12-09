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
        var order = new OnlineOrder { Referrer = "google" };
        OrderDto mapped = (OrderDto) _mapper.Map(order, order.GetType(), typeof(OrderDto));
        mapped.Referrer.ShouldBeNull();

        return Content("Hello, World!");
    }
}
