//var builder = WebApplication.CreateBuilder();

//var app = builder.Build();
//app.Urls.Add("http://*:5003");

//app.MapGet("/test", (ILogger<Program> logger) =>
//{
//    logger.LogInformation("ÇëÇóWebAPI03µÄtest");
//    return DateTime.Now;
//});

//app.Run();

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.Urls.Add("http://*:5003");


var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/test", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return System.Text.Json.JsonSerializer.Serialize(forecast);
});

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}