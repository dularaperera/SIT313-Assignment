using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;

namespace SIT313_Assignment2.Droid
{
    [Activity(Label = "SIT313_Assignment2", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Sensor)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        //private double width = 0;
        //private double height = 0;

        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height);
        //    if (width != this.width || height != this.height)
        //    {
        //        this.width = width;
        //        this.height = height;
        //        if (width > height)
        //        {
        //            outerStack.Orientation = StackOrientation.Horizontal;
        //        }
        //        else
        //        {
        //            outerStack.Orientation = StackOrientation.Vertical;
        //        }
        //    }
        //}

    }
}

