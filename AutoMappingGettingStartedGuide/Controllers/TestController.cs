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
            Name = "George Costanza"
        };
        var order = new Order
        {
            Customer = customer
        };
        var bosco = new Product
        {
            Name = "Bosco",
            Price = 4.99m
        };
        order.AddOrderLineItem(bosco, 15);

        OrderDto dto = _mapper.Map<Order, OrderDto>(order);

        dto.CustomerName.ShouldBeEquivalentTo("George Costanza");
        dto.Total.ShouldBeEquivalentTo(74.85m);

        var source = new Source
        {
            Name = "name",
            InnerSource = new InnerSource {  GetDescription = "descriptionInnerSource", Name = "InnerSource" },
            OtherInnerSource = new OtherInnerSource { Title = "title", Name = "OtherInnerSource", Description = "descriptionOtherInnerSource" }
        };
        var destination = _mapper.Map<Destination>(source);
        destination.Name.ShouldBe("name");
        destination.Description.ShouldBe("descriptionInnerSource");
        destination.Title.ShouldBe("title");

        return Content("Hello, World!");
    }
}
