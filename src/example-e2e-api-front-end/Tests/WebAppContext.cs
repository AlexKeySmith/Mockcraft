using Microsoft.AspNetCore.Mvc.Testing;

public class WebAppContext : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _webApplicationFactory;

    private WebAppContext(Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory<Program> webApplicationFactory)
    {
        _webApplicationFactory = webApplicationFactory;
    }
}