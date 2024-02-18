using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portifolio.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
	options.UseSqlServer(connectionString);
}
);

var app = builder.Build();




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();


app.Run();
