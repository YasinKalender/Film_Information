using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Film_Information.Business.Abstract;
using Film_Information.Business.Concrete;
using Film_Information.Business.FluentValidation;
using Film_Information.Business.Log;
using Film_Information.DAL.Context;
using Film_Information.Dto.Dtos.AppUserDto;
using Film_Information.Dto.Dtos.CategoryDto;
using Film_Information.Dto.Dtos.FilmDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using Film_Information.Repository.Concrete;
using Film_Information.UI.Identity;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Film_Information.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            services.AddControllersWithViews().AddFluentValidation();

            services.AddTransient<IValidator<CategoryListUpdateAddDto>, CategoryListUpdateAddValidation>();
            services.AddTransient<IValidator<FilmListAddUpdateDto>, FilmListAddUpdateValidation>();
            services.AddTransient<IValidator<AppUserRegister>, AppUserRegisterValidation>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<ICommentsRepository, CommentRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IFilmService, FilmManager>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddTransient<INLog, NLogError>();

            services.AddDbContext<ProjectContext>();

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ProjectContext>();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;

            });

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "Film";
                opt.Cookie.HttpOnly = false;
                opt.Cookie.SameSite = SameSiteMode.Strict;
                opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(1);
                opt.LoginPath = "/Home/Login";


            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");


            app.UseRouting();
            app.UseStaticFiles();
            IdentityInitializer.Identity(userManager, roleManager).Wait();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "area",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"

                    );

                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"

                    );               
            });
        }
    }
}
