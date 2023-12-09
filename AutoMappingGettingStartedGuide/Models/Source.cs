namespace AutoMappingGettingStartedGuide.Models;

class Source
{
    public string Name { get; set; }
    public InnerSource InnerSource { get; set; }
    public OtherInnerSource OtherInnerSource { get; set; }
}