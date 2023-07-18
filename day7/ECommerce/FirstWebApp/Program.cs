//Kestral Web Server ---- Cross platform Web Server
//Lighweight Server
//Linux, MacOS, Windows
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//HTTP Get request have been mapped with repsective 
//arrow Function
//app.MapGet( urlendpoint, callback function)
app.MapGet("/", () => "Hello World!");
app.MapGet("/aboutus",()=>"Welcome to IET");
app.Run();