using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLCore.Interfaces;
using GraphQLCore.Models;
using GraphQLCore.Queries;
using GraphQLCore.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using GraphQLCore.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<InvestorPortfolioTypeQuery>();
            services.AddTransient<HighRiskStocksType>();
            services.AddTransient<LowRiskStocksType>();
            services.AddTransient<RiskStocksInterface>();
            services.AddTransient<StockRiskEnum>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new InvestorPortfolioSchema(new FuncDependencyResolver(type => sp.GetService(type))));            

            



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseMvc();
        }
    }
}
