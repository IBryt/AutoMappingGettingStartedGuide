﻿namespace AutoMappingGettingStartedGuide.Models;

public class Foo
{
    public int Bar { get; set; }
    public int Baz { get; set; }
    public Foo InnerFoo { get; set; }
}