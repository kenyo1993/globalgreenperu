using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GGP.Presenter;

namespace GGP.Activities
{
    public class DescriptionActivityPanel1 : Activity
    {
        ImageButton imagepanel;
        MainPresenter presenter;
        protected override void OnCreate(Bundle bundle)
        {
            presenter = new MainPresenter(this);
            SetContentView(Resource.Layout.fragment1);

            imagepanel = FindViewById<ImageButton>(Resource.Id.imagepanel1);
            imagepanel.Click += presenter.descriptionterma1;
        }
    }
}