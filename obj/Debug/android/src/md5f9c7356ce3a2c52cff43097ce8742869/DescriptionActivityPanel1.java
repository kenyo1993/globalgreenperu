package md5f9c7356ce3a2c52cff43097ce8742869;


public class DescriptionActivityPanel1
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("GGP.Activities.DescriptionActivityPanel1, GGP", DescriptionActivityPanel1.class, __md_methods);
	}


	public DescriptionActivityPanel1 ()
	{
		super ();
		if (getClass () == DescriptionActivityPanel1.class)
			mono.android.TypeManager.Activate ("GGP.Activities.DescriptionActivityPanel1, GGP", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
