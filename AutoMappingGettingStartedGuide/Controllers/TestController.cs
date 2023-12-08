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
        var calendarEvent = new CalendarEvent
        {
            Date = new DateTime(2008, 12, 15, 20, 30, 0),
            Title = "Company Holiday Party"
        };
        CalendarEventForm calendarEventForm = _mapper.Map<CalendarEvent, CalendarEventForm>(calendarEvent);

        return Content("Hello, World!");
    }
}
