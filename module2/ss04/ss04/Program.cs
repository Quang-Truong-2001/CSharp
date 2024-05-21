
using ss04;

var builder = WebApplication.CreateBuilder(args);
var startup=new Startup(builder.Configuration);

// Add services to the container.

var services=builder.Services;
startup.ConfigureServices(services);
var webApplication = builder.Build();

// Configure the HTTP request pipeline.
var webHostEnvironment= webApplication.Environment;
startup.Configure(webHostEnvironment, webApplication);
webApplication.Run();


