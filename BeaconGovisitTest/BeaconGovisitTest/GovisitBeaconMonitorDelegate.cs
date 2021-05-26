using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shiny;
using Shiny.Beacons;
using Shiny.Notifications;

namespace BeaconGovisitTest
{
    public class GovisitBeaconMonitorDelegate : IBeaconMonitorDelegate
    {
        readonly INotificationManager notifications;
        public GovisitBeaconMonitorDelegate(INotificationManager notifications)
        {
            this.notifications = notifications;
        }

        public async Task OnStatusChanged(BeaconRegionState newStatus, BeaconRegion region)
        {
            if (newStatus == BeaconRegionState.Entered)
            {
                await notifications.Send("Notification test", "You've come uppon a Govisit beacon. Open the app to see more");
            }
        }
    }
}
