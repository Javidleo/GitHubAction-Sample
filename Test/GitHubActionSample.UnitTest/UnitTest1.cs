using GitHubActionSample.Api.Controllers;

namespace GitHubActionSample.UnitTest;

public class UnitTest1
{
    [Fact]
    public void TestCount()
    {
        var controller = new WeatherForecastController();

        var result = controller.GetCount();

        Assert.Equal(10, result);

    }
}