using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Materialsearchview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']"
	[global::Android.Runtime.Register ("com/materialsearchview/utils/SearchAdapter", DoNotGenerateAcw=true)]
	public partial class SearchAdapter : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter.SuggestionsViewHolder']"
		[global::Android.Runtime.Register ("com/materialsearchview/utils/SearchAdapter$SuggestionsViewHolder", DoNotGenerateAcw=true)]
		public partial class SuggestionsViewHolder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/materialsearchview/utils/SearchAdapter$SuggestionsViewHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SuggestionsViewHolder); }
			}

			protected SuggestionsViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_materialsearchview_utils_SearchAdapter_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter.SuggestionsViewHolder']/constructor[@name='SearchAdapter.SuggestionsViewHolder' and count(parameter)=2 and parameter[1][@type='com.materialsearchview.utils.SearchAdapter'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/materialsearchview/utils/SearchAdapter;Landroid/view/View;)V", "")]
			public unsafe SuggestionsViewHolder (global::Com.Materialsearchview.Utils.SearchAdapter __self, global::Android.Views.View p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (SuggestionsViewHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Lcom_materialsearchview_utils_SearchAdapter_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Lcom_materialsearchview_utils_SearchAdapter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/materialsearchview/utils/SearchAdapter;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_materialsearchview_utils_SearchAdapter_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_materialsearchview_utils_SearchAdapter_Landroid_view_View_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/materialsearchview/utils/SearchAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SearchAdapter); }
		}

		protected SearchAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_arrayLjava_lang_String_Lcom_materialsearchview_IOnClickListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/constructor[@name='SearchAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.materialsearchview.IOnClickListener']]"
		[Register (".ctor", "(Landroid/content/Context;[Ljava/lang/String;Lcom/materialsearchview/IOnClickListener;)V", "")]
		public unsafe SearchAdapter (global::Android.Content.Context p0, string[] p1, global::Com.Materialsearchview.IOnClickListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SearchAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;[Ljava/lang/String;Lcom/materialsearchview/IOnClickListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[Ljava/lang/String;Lcom/materialsearchview/IOnClickListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayLjava_lang_String_Lcom_materialsearchview_IOnClickListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayLjava_lang_String_Lcom_materialsearchview_IOnClickListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[Ljava/lang/String;Lcom/materialsearchview/IOnClickListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayLjava_lang_String_Lcom_materialsearchview_IOnClickListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayLjava_lang_String_Lcom_materialsearchview_IOnClickListener_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_arrayLjava_lang_String_Landroid_graphics_drawable_Drawable_ZLcom_materialsearchview_IOnClickListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/constructor[@name='SearchAdapter' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='boolean'] and parameter[5][@type='com.materialsearchview.IOnClickListener']]"
		[Register (".ctor", "(Landroid/content/Context;[Ljava/lang/String;Landroid/graphics/drawable/Drawable;ZLcom/materialsearchview/IOnClickListener;)V", "")]
		public unsafe SearchAdapter (global::Android.Content.Context p0, string[] p1, global::Android.Graphics.Drawables.Drawable p2, bool p3, global::Com.Materialsearchview.IOnClickListener p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (SearchAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;[Ljava/lang/String;Landroid/graphics/drawable/Drawable;ZLcom/materialsearchview/IOnClickListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[Ljava/lang/String;Landroid/graphics/drawable/Drawable;ZLcom/materialsearchview/IOnClickListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayLjava_lang_String_Landroid_graphics_drawable_Drawable_ZLcom_materialsearchview_IOnClickListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayLjava_lang_String_Landroid_graphics_drawable_Drawable_ZLcom_materialsearchview_IOnClickListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[Ljava/lang/String;Landroid/graphics/drawable/Drawable;ZLcom/materialsearchview/IOnClickListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayLjava_lang_String_Landroid_graphics_drawable_Drawable_ZLcom_materialsearchview_IOnClickListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayLjava_lang_String_Landroid_graphics_drawable_Drawable_ZLcom_materialsearchview_IOnClickListener_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.Utils.SearchAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.Utils.SearchAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.Utils.SearchAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.Utils.SearchAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		static IntPtr id_getFilter;
		public virtual unsafe global::Android.Widget.Filter Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Landroid/widget/Filter;", "GetGetFilterHandler")]
			get {
				if (id_getFilter == IntPtr.Zero)
					id_getFilter = JNIEnv.GetMethodID (class_ref, "getFilter", "()Landroid/widget/Filter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilter", "()Landroid/widget/Filter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.Utils.SearchAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.Utils.SearchAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.Utils.SearchAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.Utils.SearchAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Materialsearchview.Utils.SearchAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.Utils.SearchAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview.utils']/class[@name='SearchAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
