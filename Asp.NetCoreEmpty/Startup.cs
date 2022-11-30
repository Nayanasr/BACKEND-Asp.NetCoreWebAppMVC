using Asp.NetCoreEmpty.Modal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreempty
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            //services.AddControllersWithViews();
            //services.AddMvcCore();
            services.AddMvc().AddXmlDataContractSerializerFormatters();//converting json to xml format
            //services.AddMvc();
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            //app.UseFileServerOptions middleware is the combination of both app.UseStaticFiles() and app.UseDefaultFiles();
            //FileServerOptions fileServer = new FileServerOptions();
            //fileServer.EnableDefaultFiles = true;
            //fileServer.StaticFileOptions.RedirectToAppendTrailingSlash = true;
            //fileServer.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServer.DefaultFilesOptions.DefaultFileNames.Add("Landing.html");
            //app.UseFileServer(fileServer);

            //if we want to render our own default page we need to create an object of DefaultFilesOptions
            //DefaultFilesOptions defaultFiles = new DefaultFilesOptions();
            //defaultFiles.DefaultFileNames.Clear();
            //defaultFiles.DefaultFileNames.Add("Landing.html");
            //app.UseDefaultFiles(defaultFiles);

            //app.UseDefaultFiles();
            //it will return the default.html/default.htm/index.html/index.htm file

            app.UseStaticFiles();

            //ass=find out why to use app.UseDefaultFiles() before app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                // endpoints.MapGet("/", async context => {
                // await context.Response.WriteAsync(Configuration["privateKey"]);
                //await context.Response.WriteAsync("hello world!");
                //await context.Response.WriteAsync(env.EnvironmentName +" "+"this is my environment");
                endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}


//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Threading.Tasks;

//namespace aspnetcoreempty
//{
//    public class Startup
//    {

//        public IConfiguration Configuration { get; }
//        public Startup(IConfiguration configuration) {
//            Configuration = configuration;
//        }



//        // This method gets called by the runtime. Use this method to add services to the container.
//        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        public void ConfigureServices(IServiceCollection services) {
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
//            if (env.IsDevelopment()) {
//                app.UseDeveloperExceptionPage();
//            }
//            app.UseStaticFiles();
//            app.UseRouting();


//            app.UseEndpoints(endpoints => {
//                endpoints.MapGet("/", async context => {
//                     await context.Response.WriteAsync("hello world!");
//                    await context.Response.WriteAsync(Configuration["privateKey"]);
//                    await context.Response.WriteAsync(env.EnvironmentName + " " + "this is my environment");

//                });
//            });
//        }
//    }
//}