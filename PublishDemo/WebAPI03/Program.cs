

var builder = WebApplication.CreateBuilder();

var app = builder.Build();
app.Urls.Add("http://*:5003");

app.MapGet("/test", (ILogger<Program> logger) =>
{
    logger.LogInformation("ÇëÇóWebAPI03µÄtest");
    return "WebAPI03 OK";
});

app.Run();

