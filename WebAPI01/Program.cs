var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.Urls.Add("http://*:5001");

app.MapGet("/test", (ILogger<Program> logger) =>
{
    logger.LogInformation("����WebAPI01��test");
    return "WebAPI01 OK";
});

app.Run();
