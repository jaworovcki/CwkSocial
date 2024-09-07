using CwkSocial.Dal;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Api.Registrars;
public class DbRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        var conectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<DataContext>(options => 
        {
            options.UseSqlServer(conectionString);
        });
    }
}