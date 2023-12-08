namespace AutoMappingGettingStartedGuide.Models;

public class SourceDto
{
    public SourceDto(int valueParamSomeOtherName)
    {
        _value = valueParamSomeOtherName;
    }
    private int _value;
    public int Value
    {
        get { return _value; }
    }
}