using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace GViewer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private ILocationGettable _locationGetter;

        public MainPage()
        {
            InitializeComponent();

            this._locationGetter = DependencyService.Get<ILocationGettable>();
        }

        internal void OnShowLocation(object sender, EventArgs args)
        {
            var location = this._locationGetter.GetLocation();

            this.latitudeLabel.Text = $"緯度{location.Latitude:F2}";
            this.longitudeLabel.Text =$"経度{location.Longitude:F2}";
        }

    }
}
