using HelloRun;
using Xunit;
using Xunit.Abstractions;

namespace HelloRun.Tests;

public class UnitTest1
{
    [Fact(DisplayName = "Test1")]
    public async void Test1()
    {
        var helloRun = new HelloRun();

        var result = await helloRun.Run();

        Assert.Equal("Hello World", result);
    }

    [Fact(DisplayName = "Test2")]
    public async void Test2()
    {
        var helloRun = new HelloRun();

        var result = await helloRun.Run();

        Assert.Equal("Hello, World!", result);
    }
}