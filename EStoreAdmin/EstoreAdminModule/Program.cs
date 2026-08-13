using EstoreModel.ServiceContracts;
using EStoreRepository;
using EStoreService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Predefine method for AllController to create an object
//builder.Services.AddControllers();
//If view is there then used below
builder.Services.AddControllersWithViews();

//This will help us to create an Object 
//Inversion of Control ,dynamically we are creating object
//by registering in builder.Service Collection
builder.Services.Add(new ServiceDescriptor(
    typeof(IBrandService),
    typeof(BrandService),
    ServiceLifetime.Transient));


string connstring = builder.Configuration.GetConnectionString("OracleDbConnection");
builder.Services.AddDbContext<BrandRepository>(options =>
{
    options.UseOracle(connstring);
});

var app = builder.Build();
app.UseStaticFiles();  // it help me to download the required file like bootstrap
app.UseRouting();//Define routing
app.MapControllers();//call to all controller without view

app.Run();
