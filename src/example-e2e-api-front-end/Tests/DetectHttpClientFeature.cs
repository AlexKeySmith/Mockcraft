
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using Microsoft.AspNetCore.Mvc.Testing;

public partial class DetectHttpClientFeature
{

    [Scenario]
    public void Should_find_http_client()
    {
        Runner.RunScenario(
            Given_the_website_is_running,
            When_moo,
            Then_moo
        );
    }
}