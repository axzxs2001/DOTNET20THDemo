var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/getfile", () =>
{
    var files = System.IO.Directory.GetFiles("/app/data");
    return files;
});

app.Run();
