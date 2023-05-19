using AmigosFsGestorDocumental.Services;
using AmigosFsGestorDocumental.Services.Interfaces;

namespace AmigosFsGestorDocumental
{
    public static class AppConfiguration
    {
        public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddSingleton<IFileDatabaseService, FileDatabaseService>();
            
            return builder;
        }
    }
}
