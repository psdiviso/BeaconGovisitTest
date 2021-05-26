using Shiny;
using Shiny.Beacons;
using Shiny.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BeaconGovisitTest
{
    public class BackgroundBeaconsAtStartSetup : IShinyStartupTask
    {
        public async void Start()
        {
            var notification = ShinyHost.Resolve<INotificationManager>();
            var access = await notification.RequestAccess();
            if (access == AccessState.Available)
            {
                await ShinyHost.Resolve<IBeaconMonitoringManager>().StopAllMonitoring();
                Guid uuid = Guid.Parse("b641c787-209e-459a-97d8-52dd271185d7");
                await ShinyHost.Resolve<IBeaconMonitoringManager>().StartMonitoring(new BeaconRegion("MySupportBeacon", uuid));
            }
        }
    }
}
