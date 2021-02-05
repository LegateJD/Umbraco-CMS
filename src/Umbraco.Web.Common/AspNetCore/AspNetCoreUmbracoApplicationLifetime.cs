using Microsoft.Extensions.Hosting;
using Umbraco.Core.Hosting;

namespace Umbraco.Web.Common.AspNetCore
{
    public class AspNetCoreUmbracoApplicationLifetime : IUmbracoApplicationLifetime
    {
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public AspNetCoreUmbracoApplicationLifetime(IHostApplicationLifetime hostApplicationLifetime)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        public bool IsRestarting { get; set; }

        public void Restart()
        {
            IsRestarting = true;
            _hostApplicationLifetime.StopApplication();
        }
    }
}