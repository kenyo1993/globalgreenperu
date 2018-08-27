using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace GGP.Fragments
{
    public class KitsSolares : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static KitsSolares NewInstance()
        {
            var frag3 = new KitsSolares { Arguments = new Bundle() };
            return frag3;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.fragment3, null);
        }
    }
}