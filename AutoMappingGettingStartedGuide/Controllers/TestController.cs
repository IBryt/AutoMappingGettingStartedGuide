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
        var customer = new Customer
        {
            Name = "Bob"
        };

        var order = new Order
        {
            Customer = customer,
            Total = 15.8m
        };

        var orderDto = _mapper.Map<Order, OrderDto>(order);

        orderDto.CustomerName = "Joe";

        _mapper.Map(orderDto, order);

        order.Customer.Name.ShouldBeEquivalentTo("Joe");

        return Content("Hello, World!");
    }
}
