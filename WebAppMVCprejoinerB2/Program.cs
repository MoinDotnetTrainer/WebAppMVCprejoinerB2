using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using Microsoft.EntityFrameworkCore;


namespace WebAppMVCprejoinerB2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // PAssing the connection string

            builder.Services.AddDbContext<AppDatabase>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Constr")));


            // here

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60);
                options.Cookie.IsEssential = true;
            });

            builder.Services.AddScoped<IEmpRepo, EmpRepo>(); // DI
            builder.Services.AddScoped<IBookRepo, BookRepo>(); // DI
            builder.Services.AddScoped<ILogin, Loginrepo>(); //
                                                             // 
            builder.Services.AddScoped<IOneToone, OnetoOnerepo>(); // DI

            builder.Services.AddScoped<IOneToMany, CountryRepo>(); // DI

            builder.Services.AddScoped<ILoading, LoadingRepo>(); // DI

            builder.Services.AddScoped<ICityPin, Cityrepo>(); // DI

            builder.Services.AddScoped<IUserInterface, IUserClass>(); // DI
            builder.Services.AddScoped<ITaskInterface, ITaskClass>(); //
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Action}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
