using System.Configuration;
using CourseManagement.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IBankAccountRepository, BankAccountRepository>();
builder.Services.AddDbContext<BankContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    // pattern: "{controller=Home}/{action=Index}/{id?}");
 pattern: "{controller=Bank}/{action=Transfer}");

app.Run();
