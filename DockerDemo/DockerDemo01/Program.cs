var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/test", () =>
{
    return $"OK:{DateTime.Now}";
});

app.MapGet("/getfiles", () =>
{
    var files = System.IO.Directory.GetFiles("/app/data");
    return files;
});

app.Run();
