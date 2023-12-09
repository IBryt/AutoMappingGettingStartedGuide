namespace AutoMappingGettingStartedGuide.Models;

public class Order
{
    public decimal Total { get; set; }
    public Customer Customer { get; set; }
}