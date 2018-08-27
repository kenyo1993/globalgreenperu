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
using GGP.Fragments;

namespace GGP.Presenter
{
    public class MainPresenter
    {
        Context context;
        public MainPresenter(Context _context)
        {
            this.context = _context;
        }

        public MainPresenter(PanelesSolares panelesSolares)
        {
        }

        public void descriptionterma1(object sender, EventArgs args)
        {
            Intent newActivity = new Intent(this.context, typeof(TermaSuntaskDescrption));
            this.context.StartActivity(newActivity);
        }
    }
}