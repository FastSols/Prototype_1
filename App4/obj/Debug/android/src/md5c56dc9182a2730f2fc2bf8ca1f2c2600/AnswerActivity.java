package md5c56dc9182a2730f2fc2bf8ca1f2c2600;


public class AnswerActivity
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
		mono.android.Runtime.register ("App4.Activities.AnswerActivity, Clarify", AnswerActivity.class, __md_methods);
	}


	public AnswerActivity ()
	{
		super ();
		if (getClass () == AnswerActivity.class)
			mono.android.TypeManager.Activate ("App4.Activities.AnswerActivity, Clarify", "", this, new java.lang.Object[] {  });
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
