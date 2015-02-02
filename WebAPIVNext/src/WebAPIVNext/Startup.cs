using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace WebAPIVNext
{
	public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
			// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
			app.UseMvc();
			app.UseWelcomePage();
        }
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
		}
	}
}
