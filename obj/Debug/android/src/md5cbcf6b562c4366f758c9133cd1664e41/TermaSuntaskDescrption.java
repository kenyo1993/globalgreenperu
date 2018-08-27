package md5cbcf6b562c4366f758c9133cd1664e41;


public class TermaSuntaskDescrption
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
		mono.android.Runtime.register ("GGP.Fragments.TermaSuntaskDescrption, GGP", TermaSuntaskDescrption.class, __md_methods);
	}


	public TermaSuntaskDescrption ()
	{
		super ();
		if (getClass () == TermaSuntaskDescrption.class)
			mono.android.TypeManager.Activate ("GGP.Fragments.TermaSuntaskDescrption, GGP", "", this, new java.lang.Object[] {  });
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
