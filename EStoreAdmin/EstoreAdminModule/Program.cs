var builder = WebApplication.CreateBuilder(args);

//Predefine method for AllController to create an object
//builder.Services.AddControllers();
//If view is there then used below
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();  // it help me to download the required file like bootstrap
app.UseRouting();//Define routing
app.MapControllers();//call to all controller without view

app.Run();
