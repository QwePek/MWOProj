using P05Shop.API.Models;
using P05Shop.API.Services.ProductService;
using P06Shop.Shared.Services.BookService;
using P06Shop.Shared.Services.ProductService;
using Microsoft.EntityFrameworkCore;

class ProgramMain
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.run(args);
    }
}

public class Program
{
    WebApplication? app;

    public void run(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //Microsoft.EntityFrameworkCore.SqlServer
        builder.Services.AddDbContext<DataContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IBookService, BookService>();

        builder.Services.AddControllersWithViews();

        app = builder.Build();
        if (!app.Environment.IsDevelopment())
        {
            app.UseHsts();
        }
        else
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Book}/{action=Index}/{id?}");

        app.Run();
    }

    public void end()
    {
        if(app != null)
            app.StopAsync();
    }
}