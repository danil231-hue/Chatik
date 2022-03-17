using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http.Connections;
using Chat;

namespace Chat
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chat",
                    options => {
                        options.ApplicationMaxBufferSize = 64;
                        options.TransportMaxBufferSize = 64;
                        options.LongPolling.PollTimeout = System.TimeSpan.FromMinutes(1);
                        options.Transports = HttpTransportType.LongPolling | HttpTransportType.WebSockets;
                    });
            });
        }
    }
}