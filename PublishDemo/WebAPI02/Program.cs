var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.Urls.Add("http://*:5002");

app.MapGet("/test", (ILogger<Program> logger) =>
{
    logger.LogInformation("ÇëÇóWebAPI02µÄtest");
    return "WebAPI02 OK";
});

app.Run();

