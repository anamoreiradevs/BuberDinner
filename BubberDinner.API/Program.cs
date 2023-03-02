using BubberDinner.Application;
using BubberDinner.Infrastructure;
using BuberDinner.Application;

var builder = WebApplication.CreateBuilder(args);
{ 
    builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddApplication();
    builder.Services.AddControllers();
}
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
