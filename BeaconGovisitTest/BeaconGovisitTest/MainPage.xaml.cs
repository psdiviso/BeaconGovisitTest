using Shiny;
using Shiny.Beacons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeaconGovisitTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //SetupBeaconMonitoring();
        }

        private async void SetupBeaconMonitoring()
        {
            await ShinyHost.Resolve<IBeaconMonitoringManager>().StopAllMonitoring();
            Guid uuid = Guid.Parse("b641c787-209e-459a-97d8-52dd271185d7");
            await ShinyHost.Resolve<IBeaconMonitoringManager>().StartMonitoring(new BeaconRegion("MySupportBeacon", uuid));
        }
    }
}
