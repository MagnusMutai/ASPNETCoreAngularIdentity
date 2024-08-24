var builder = WebApplication.CreateBuilder(args);
var app = builder.BuildWithSpa();

app.MapGet("/", () => "Hello World!");

app.Run();
