using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using GGP.Presenter;
using System;

namespace GGP.Fragments
{
    public class PanelesSolares : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public static PanelesSolares NewInstance()
        {
            var frag1 = new PanelesSolares { Arguments = new Bundle() };
            return frag1;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.fragment1, null);
        }
    }
}