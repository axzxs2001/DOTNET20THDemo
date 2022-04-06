var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.Urls.Add("http://*:5001");

app.MapGet("/test", (ILogger<Program> logger) =>
{
    logger.LogInformation("ÇëÇóWebAPI01µÄtest");
    return "WebAPI01 OK";
});

app.Run();
