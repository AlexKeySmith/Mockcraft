using LightBDD.XUnit2;
using Microsoft.AspNetCore.Mvc.Testing;

public partial class DetectHttpClientFeature : FeatureFixture
{

    private void Given_the_website_is_running()
    {
       // Arrange
        var client = _webApplicationFactory.CreateClient();
    }

    private void When_moo()
    {
        
    }

    private void Then_moo()
    {

    }
}