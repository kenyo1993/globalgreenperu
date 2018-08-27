using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace GGP.Fragments
{
    public class TermasSolares : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
        }

        public static TermasSolares NewInstance()
        {
            var frag2 = new TermasSolares { Arguments = new Bundle() };
            return frag2;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.fragment2, null);
        }

    }
}