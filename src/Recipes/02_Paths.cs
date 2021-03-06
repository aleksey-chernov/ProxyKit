﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ProxyKit.Recipies
{
    public class Paths : ExampleBase<Paths.Startup>
    {
        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddProxy();
            }

            public void Configure(IApplicationBuilder app)
            {
                app.RunProxy(
                    "/app1",
                    context => context
                        .ForwardTo("http://localhost:5001/foo/")
                        .ApplyXForwardedHeaders()
                        .Execute());

                app.RunProxy(
                    "/app2",
                    context => context
                        .ForwardTo("http://localhost:5002/bar/")
                        .ApplyXForwardedHeaders()
                        .Execute());
            }
        }
    }
}