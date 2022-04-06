var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.Urls.Add("http://*:5002");

app.MapGet("/test", (ILogger<Program> logger) =>
{
    logger.LogInformation("����WebAPI02��test");
    return "WebAPI02 OK";
});

app.Run();

