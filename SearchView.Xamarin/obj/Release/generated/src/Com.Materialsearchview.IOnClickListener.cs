using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Materialsearchview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.materialsearchview']/interface[@name='IOnClickListener']"
	[Register ("com/materialsearchview/IOnClickListener", "", "Com.Materialsearchview.IOnClickListenerInvoker")]
	public partial interface IOnClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/interface[@name='IOnClickListener']/method[@name='itemViewOnClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("itemViewOnClick", "(Landroid/view/View;I)V", "GetItemViewOnClick_Landroid_view_View_IHandler:Com.Materialsearchview.IOnClickListenerInvoker, SearchView.Xamarin")]
		void ItemViewOnClick (global::Android.Views.View p0, int p1);

	}

	[global::Android.Runtime.Register ("com/materialsearchview/IOnClickListener", DoNotGenerateAcw=true)]
	internal class IOnClickListenerInvoker : global::Java.Lang.Object, IOnClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/materialsearchview/IOnClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.materialsearchview.IOnClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_itemViewOnClick_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetItemViewOnClick_Landroid_view_View_IHandler ()
		{
			if (cb_itemViewOnClick_Landroid_view_View_I == null)
				cb_itemViewOnClick_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ItemViewOnClick_Landroid_view_View_I);
			return cb_itemViewOnClick_Landroid_view_View_I;
		}

		static void n_ItemViewOnClick_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Materialsearchview.IOnClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.IOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ItemViewOnClick (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_itemViewOnClick_Landroid_view_View_I;
		public unsafe void ItemViewOnClick (global::Android.Views.View p0, int p1)
		{
			if (id_itemViewOnClick_Landroid_view_View_I == IntPtr.Zero)
				id_itemViewOnClick_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "itemViewOnClick", "(Landroid/view/View;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_itemViewOnClick_Landroid_view_View_I, __args);
		}

	}

	public partial class ClickEventArgs : global::System.EventArgs {

		public ClickEventArgs (global::Android.Views.View p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/materialsearchview/IOnClickListenerImplementor")]
	internal sealed partial class IOnClickListenerImplementor : global::Java.Lang.Object, IOnClickListener {

		object sender;

		public IOnClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/materialsearchview/IOnClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ClickEventArgs> Handler;
#pragma warning restore 0649

		public void ItemViewOnClick (global::Android.Views.View p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ClickEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
