using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Text;

using Xamarin.Forms;
using Xamarin.Essentials;
using System.Windows.Input;

namespace GViewer.ViewModels
{
    class LocationViewModel : INotifyPropertyChanged, ICommand
    {
        private Location _location;
        private ILocationGettable _locationGetter;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public LocationViewModel()
        {
            this._locationGetter = DependencyService.Get<ILocationGettable>();
            //this._location = this._locationGetter.GetLocation();

        }


        public Location Location
        {
            private set
            {
                if (this._location != value)
                {
                    this._location = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Location"));
                }
            }

            get
            {
                return this._location;
            }
        }


        public void Execute(object arg)
        {
            this.Location = this._locationGetter.GetLocation();
        }


        public bool CanExecute(object arg)
        {
            return true;
        }


        internal void OnLocation(object sender, EventArgs args)
        {

        }



    }
}
