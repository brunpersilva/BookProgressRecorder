using BookProgressRecorder.Infrasctructure.Configurations;
using BookProgressRecorder.Repository.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BookProgressRecorder.Dependencies
{
    public static class InjectDependencies
    {
        public static void AddDependencies(this IServiceCollection services, IAppConfiguration appConfiguration)
        {
            services.AddDbContext<BookProgressContext>(
                 options => options.UseSqlServer(appConfiguration.ConnectionString));
        }
    }
}