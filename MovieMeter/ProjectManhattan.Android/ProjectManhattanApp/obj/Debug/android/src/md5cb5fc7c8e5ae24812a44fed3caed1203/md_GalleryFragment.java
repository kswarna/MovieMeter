package md5cb5fc7c8e5ae24812a44fed3caed1203;


public class md_GalleryFragment
	extends md5cb5fc7c8e5ae24812a44fed3caed1203.md_tab_baseFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ProjectManhattanApp.Fragments.md_GalleryFragment, ProjectManhattanApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", md_GalleryFragment.class, __md_methods);
	}


	public md_GalleryFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == md_GalleryFragment.class)
			mono.android.TypeManager.Activate ("ProjectManhattanApp.Fragments.md_GalleryFragment, ProjectManhattanApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
