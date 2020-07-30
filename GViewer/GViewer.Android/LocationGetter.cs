using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Org.Xml.Sax.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(GViewer.Droid.LocationGetter))]
namespace GViewer.Droid
{
    class LocationGetter : ILocationGettable
    {
        private Location _location;

        public LocationGetter()
        {
            this.SetLocation();  
        }



        private async void SetLocation()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            if (location != null)
            {
                this._location = location;
            }
        }


        public Location GetLocation()
        {
            return this._location;
        }
    }
}