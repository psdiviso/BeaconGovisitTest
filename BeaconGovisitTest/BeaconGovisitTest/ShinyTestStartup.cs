using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shiny;

namespace BeaconGovisitTest
{
    public class ShinyTestStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            services.UseNotifications();
            services.UseBeaconMonitoring<GovisitBeaconMonitorDelegate>();
            services.AddSingleton<BackgroundBeaconsAtStartSetup>();
        }
    }
}
