using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Essentials;


[assembly: Dependency(typeof(GViewer.Droid.LocationGetter))]

namespace GViewer.Droid
{
    class LocationGetter : ILocationGettable
    {
       public Location GetLocation()
        {

                var task = Geolocation.GetLastKnownLocationAsync();
                var location = task.Result; 

                return location;

        }
    }
}