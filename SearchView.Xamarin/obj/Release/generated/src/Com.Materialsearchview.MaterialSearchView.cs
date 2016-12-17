using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Materialsearchview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']"
	[global::Android.Runtime.Register ("com/materialsearchview/MaterialSearchView", DoNotGenerateAcw=true)]
	public partial class MaterialSearchView : global::Android.Widget.FrameLayout, global::Android.Widget.Filter.IFilterListener, global::Com.Materialsearchview.IOnClickListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/field[@name='REQUEST_VOICE']"
		[Register ("REQUEST_VOICE")]
		public const int RequestVoice = (int) 9999;

		static IntPtr iOnClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/field[@name='iOnClickListener']"
		[Register ("iOnClickListener")]
		public global::Com.Materialsearchview.IOnClickListener IOnClickListener {
			get {
				if (iOnClickListener_jfieldId == IntPtr.Zero)
					iOnClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "iOnClickListener", "Lcom/materialsearchview/IOnClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, iOnClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.IOnClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (iOnClickListener_jfieldId == IntPtr.Zero)
					iOnClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "iOnClickListener", "Lcom/materialsearchview/IOnClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, iOnClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.materialsearchview']/interface[@name='MaterialSearchView.OnQueryTextListener']"
		[Register ("com/materialsearchview/MaterialSearchView$OnQueryTextListener", "", "Com.Materialsearchview.MaterialSearchView/IOnQueryTextListenerInvoker")]
		public partial interface IOnQueryTextListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/interface[@name='MaterialSearchView.OnQueryTextListener']/method[@name='onQueryTextChange' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onQueryTextChange", "(Ljava/lang/String;)Z", "GetOnQueryTextChange_Ljava_lang_String_Handler:Com.Materialsearchview.MaterialSearchView/IOnQueryTextListenerInvoker, SearchView.Xamarin")]
			bool OnQueryTextChange (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/interface[@name='MaterialSearchView.OnQueryTextListener']/method[@name='onQueryTextSubmit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onQueryTextSubmit", "(Ljava/lang/String;)Z", "GetOnQueryTextSubmit_Ljava_lang_String_Handler:Com.Materialsearchview.MaterialSearchView/IOnQueryTextListenerInvoker, SearchView.Xamarin")]
			bool OnQueryTextSubmit (string p0);

		}

		[global::Android.Runtime.Register ("com/materialsearchview/MaterialSearchView$OnQueryTextListener", DoNotGenerateAcw=true)]
		internal class IOnQueryTextListenerInvoker : global::Java.Lang.Object, IOnQueryTextListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/materialsearchview/MaterialSearchView$OnQueryTextListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnQueryTextListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnQueryTextListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnQueryTextListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.materialsearchview.MaterialSearchView.OnQueryTextListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnQueryTextListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onQueryTextChange_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnQueryTextChange_Ljava_lang_String_Handler ()
			{
				if (cb_onQueryTextChange_Ljava_lang_String_ == null)
					cb_onQueryTextChange_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnQueryTextChange_Ljava_lang_String_);
				return cb_onQueryTextChange_Ljava_lang_String_;
			}

			static bool n_OnQueryTextChange_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnQueryTextChange (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onQueryTextChange_Ljava_lang_String_;
			public unsafe bool OnQueryTextChange (string p0)
			{
				if (id_onQueryTextChange_Ljava_lang_String_ == IntPtr.Zero)
					id_onQueryTextChange_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextChange", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextChange_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_onQueryTextSubmit_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnQueryTextSubmit_Ljava_lang_String_Handler ()
			{
				if (cb_onQueryTextSubmit_Ljava_lang_String_ == null)
					cb_onQueryTextSubmit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnQueryTextSubmit_Ljava_lang_String_);
				return cb_onQueryTextSubmit_Ljava_lang_String_;
			}

			static bool n_OnQueryTextSubmit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnQueryTextSubmit (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onQueryTextSubmit_Ljava_lang_String_;
			public unsafe bool OnQueryTextSubmit (string p0)
			{
				if (id_onQueryTextSubmit_Ljava_lang_String_ == IntPtr.Zero)
					id_onQueryTextSubmit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextSubmit", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextSubmit_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		public partial class QueryTextChangeEventArgs : global::System.EventArgs {

			public QueryTextChangeEventArgs (bool handled, string p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class QueryTextSubmitEventArgs : global::System.EventArgs {

			public QueryTextSubmitEventArgs (bool handled, string p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/materialsearchview/MaterialSearchView_OnQueryTextListenerImplementor")]
		internal sealed partial class IOnQueryTextListenerImplementor : global::Java.Lang.Object, IOnQueryTextListener {

			object sender;

			public IOnQueryTextListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/materialsearchview/MaterialSearchView_OnQueryTextListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QueryTextChangeEventArgs> OnQueryTextChangeHandler;
#pragma warning restore 0649

			public bool OnQueryTextChange (string p0)
			{
				var __h = OnQueryTextChangeHandler;
				if (__h == null)
					return false;
				var __e = new QueryTextChangeEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<QueryTextSubmitEventArgs> OnQueryTextSubmitHandler;
#pragma warning restore 0649

			public bool OnQueryTextSubmit (string p0)
			{
				var __h = OnQueryTextSubmitHandler;
				if (__h == null)
					return false;
				var __e = new QueryTextSubmitEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnQueryTextListenerImplementor value)
			{
				return value.OnQueryTextChangeHandler == null && value.OnQueryTextSubmitHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView.SavedState']"
		[global::Android.Runtime.Register ("com/materialsearchview/MaterialSearchView$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/materialsearchview/MaterialSearchView$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.materialsearchview']/interface[@name='MaterialSearchView.SearchViewListener']"
		[Register ("com/materialsearchview/MaterialSearchView$SearchViewListener", "", "Com.Materialsearchview.MaterialSearchView/ISearchViewListenerInvoker")]
		public partial interface ISearchViewListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/interface[@name='MaterialSearchView.SearchViewListener']/method[@name='onSearchViewClosed' and count(parameter)=0]"
			[Register ("onSearchViewClosed", "()V", "GetOnSearchViewClosedHandler:Com.Materialsearchview.MaterialSearchView/ISearchViewListenerInvoker, SearchView.Xamarin")]
			void OnSearchViewClosed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/interface[@name='MaterialSearchView.SearchViewListener']/method[@name='onSearchViewShown' and count(parameter)=0]"
			[Register ("onSearchViewShown", "()V", "GetOnSearchViewShownHandler:Com.Materialsearchview.MaterialSearchView/ISearchViewListenerInvoker, SearchView.Xamarin")]
			void OnSearchViewShown ();

		}

		[global::Android.Runtime.Register ("com/materialsearchview/MaterialSearchView$SearchViewListener", DoNotGenerateAcw=true)]
		internal class ISearchViewListenerInvoker : global::Java.Lang.Object, ISearchViewListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/materialsearchview/MaterialSearchView$SearchViewListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISearchViewListenerInvoker); }
			}

			IntPtr class_ref;

			public static ISearchViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISearchViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.materialsearchview.MaterialSearchView.SearchViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISearchViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSearchViewClosed;
#pragma warning disable 0169
			static Delegate GetOnSearchViewClosedHandler ()
			{
				if (cb_onSearchViewClosed == null)
					cb_onSearchViewClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSearchViewClosed);
				return cb_onSearchViewClosed;
			}

			static void n_OnSearchViewClosed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSearchViewClosed ();
			}
#pragma warning restore 0169

			IntPtr id_onSearchViewClosed;
			public unsafe void OnSearchViewClosed ()
			{
				if (id_onSearchViewClosed == IntPtr.Zero)
					id_onSearchViewClosed = JNIEnv.GetMethodID (class_ref, "onSearchViewClosed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSearchViewClosed);
			}

			static Delegate cb_onSearchViewShown;
#pragma warning disable 0169
			static Delegate GetOnSearchViewShownHandler ()
			{
				if (cb_onSearchViewShown == null)
					cb_onSearchViewShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSearchViewShown);
				return cb_onSearchViewShown;
			}

			static void n_OnSearchViewShown (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSearchViewShown ();
			}
#pragma warning restore 0169

			IntPtr id_onSearchViewShown;
			public unsafe void OnSearchViewShown ()
			{
				if (id_onSearchViewShown == IntPtr.Zero)
					id_onSearchViewShown = JNIEnv.GetMethodID (class_ref, "onSearchViewShown", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSearchViewShown);
			}

		}

		[global::Android.Runtime.Register ("mono/com/materialsearchview/MaterialSearchView_SearchViewListenerImplementor")]
		internal sealed partial class ISearchViewListenerImplementor : global::Java.Lang.Object, ISearchViewListener {

			object sender;

			public ISearchViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/materialsearchview/MaterialSearchView_SearchViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnSearchViewClosedHandler;
#pragma warning restore 0649

			public void OnSearchViewClosed ()
			{
				var __h = OnSearchViewClosedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnSearchViewShownHandler;
#pragma warning restore 0649

			public void OnSearchViewShown ()
			{
				var __h = OnSearchViewShownHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ISearchViewListenerImplementor value)
			{
				return value.OnSearchViewClosedHandler == null && value.OnSearchViewShownHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/materialsearchview/MaterialSearchView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaterialSearchView); }
		}

		protected MaterialSearchView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/constructor[@name='MaterialSearchView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MaterialSearchView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MaterialSearchView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/constructor[@name='MaterialSearchView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MaterialSearchView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MaterialSearchView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/constructor[@name='MaterialSearchView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MaterialSearchView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MaterialSearchView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_isSearchOpen;
#pragma warning disable 0169
		static Delegate GetIsSearchOpenHandler ()
		{
			if (cb_isSearchOpen == null)
				cb_isSearchOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSearchOpen);
			return cb_isSearchOpen;
		}

		static bool n_IsSearchOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSearchOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isSearchOpen;
		public virtual unsafe bool IsSearchOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='isSearchOpen' and count(parameter)=0]"
			[Register ("isSearchOpen", "()Z", "GetIsSearchOpenHandler")]
			get {
				if (id_isSearchOpen == IntPtr.Zero)
					id_isSearchOpen = JNIEnv.GetMethodID (class_ref, "isSearchOpen", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSearchOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSearchOpen", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_closeSearch;
#pragma warning disable 0169
		static Delegate GetCloseSearchHandler ()
		{
			if (cb_closeSearch == null)
				cb_closeSearch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseSearch);
			return cb_closeSearch;
		}

		static void n_CloseSearch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSearch ();
		}
#pragma warning restore 0169

		static IntPtr id_closeSearch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='closeSearch' and count(parameter)=0]"
		[Register ("closeSearch", "()V", "GetCloseSearchHandler")]
		public virtual unsafe void CloseSearch ()
		{
			if (id_closeSearch == IntPtr.Zero)
				id_closeSearch = JNIEnv.GetMethodID (class_ref, "closeSearch", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeSearch);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeSearch", "()V"));
			} finally {
			}
		}

		static Delegate cb_dismissSuggestions;
#pragma warning disable 0169
		static Delegate GetDismissSuggestionsHandler ()
		{
			if (cb_dismissSuggestions == null)
				cb_dismissSuggestions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DismissSuggestions);
			return cb_dismissSuggestions;
		}

		static void n_DismissSuggestions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DismissSuggestions ();
		}
#pragma warning restore 0169

		static IntPtr id_dismissSuggestions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='dismissSuggestions' and count(parameter)=0]"
		[Register ("dismissSuggestions", "()V", "GetDismissSuggestionsHandler")]
		public virtual unsafe void DismissSuggestions ()
		{
			if (id_dismissSuggestions == IntPtr.Zero)
				id_dismissSuggestions = JNIEnv.GetMethodID (class_ref, "dismissSuggestions", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dismissSuggestions);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismissSuggestions", "()V"));
			} finally {
			}
		}

		static Delegate cb_hideKeyboard_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetHideKeyboard_Landroid_view_View_Handler ()
		{
			if (cb_hideKeyboard_Landroid_view_View_ == null)
				cb_hideKeyboard_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HideKeyboard_Landroid_view_View_);
			return cb_hideKeyboard_Landroid_view_View_;
		}

		static void n_HideKeyboard_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HideKeyboard (p0);
		}
#pragma warning restore 0169

		static IntPtr id_hideKeyboard_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='hideKeyboard' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("hideKeyboard", "(Landroid/view/View;)V", "GetHideKeyboard_Landroid_view_View_Handler")]
		public virtual unsafe void HideKeyboard (global::Android.Views.View p0)
		{
			if (id_hideKeyboard_Landroid_view_View_ == IntPtr.Zero)
				id_hideKeyboard_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "hideKeyboard", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideKeyboard_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideKeyboard", "(Landroid/view/View;)V"), __args);
			} finally {
			}
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
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ItemViewOnClick (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_itemViewOnClick_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='itemViewOnClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("itemViewOnClick", "(Landroid/view/View;I)V", "GetItemViewOnClick_Landroid_view_View_IHandler")]
		public virtual unsafe void ItemViewOnClick (global::Android.Views.View p0, int p1)
		{
			if (id_itemViewOnClick_Landroid_view_View_I == IntPtr.Zero)
				id_itemViewOnClick_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "itemViewOnClick", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_itemViewOnClick_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "itemViewOnClick", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onFilterComplete_I;
#pragma warning disable 0169
		static Delegate GetOnFilterComplete_IHandler ()
		{
			if (cb_onFilterComplete_I == null)
				cb_onFilterComplete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFilterComplete_I);
			return cb_onFilterComplete_I;
		}

		static void n_OnFilterComplete_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFilterComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onFilterComplete_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='onFilterComplete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onFilterComplete", "(I)V", "GetOnFilterComplete_IHandler")]
		public virtual unsafe void OnFilterComplete (int p0)
		{
			if (id_onFilterComplete_I == IntPtr.Zero)
				id_onFilterComplete_I = JNIEnv.GetMethodID (class_ref, "onFilterComplete", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFilterComplete_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFilterComplete", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAdapter_Landroid_widget_ListAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Handler ()
		{
			if (cb_setAdapter_Landroid_widget_ListAdapter_ == null)
				cb_setAdapter_Landroid_widget_ListAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Landroid_widget_ListAdapter_);
			return cb_setAdapter_Landroid_widget_ListAdapter_;
		}

		static void n_SetAdapter_Landroid_widget_ListAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.IListAdapter p0 = (global::Android.Widget.IListAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdapter_Landroid_widget_ListAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.ListAdapter']]"
		[Register ("setAdapter", "(Landroid/widget/ListAdapter;)V", "GetSetAdapter_Landroid_widget_ListAdapter_Handler")]
		public virtual unsafe void SetAdapter (global::Android.Widget.IListAdapter p0)
		{
			if (id_setAdapter_Landroid_widget_ListAdapter_ == IntPtr.Zero)
				id_setAdapter_Landroid_widget_ListAdapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdapter_Landroid_widget_ListAdapter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAnimationDuration_I;
#pragma warning disable 0169
		static Delegate GetSetAnimationDuration_IHandler ()
		{
			if (cb_setAnimationDuration_I == null)
				cb_setAnimationDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimationDuration_I);
			return cb_setAnimationDuration_I;
		}

		static void n_SetAnimationDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setAnimationDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimationDuration", "(I)V", "GetSetAnimationDuration_IHandler")]
		public virtual unsafe void SetAnimationDuration (int p0)
		{
			if (id_setAnimationDuration_I == IntPtr.Zero)
				id_setAnimationDuration_I = JNIEnv.GetMethodID (class_ref, "setAnimationDuration", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnimationDuration_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationDuration", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setBackIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetBackIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBackIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setBackIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetBackIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setBackIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackIcon_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackIcon", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCloseIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetCloseIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setCloseIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setCloseIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCloseIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setCloseIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetCloseIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCloseIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCloseIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setCloseIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setCloseIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetCloseIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetCloseIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setCloseIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setCloseIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setCloseIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCloseIcon_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCloseIcon", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCursorDrawable_I;
#pragma warning disable 0169
		static Delegate GetSetCursorDrawable_IHandler ()
		{
			if (cb_setCursorDrawable_I == null)
				cb_setCursorDrawable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCursorDrawable_I);
			return cb_setCursorDrawable_I;
		}

		static void n_SetCursorDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCursorDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCursorDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setCursorDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCursorDrawable", "(I)V", "GetSetCursorDrawable_IHandler")]
		public virtual unsafe void SetCursorDrawable (int p0)
		{
			if (id_setCursorDrawable_I == IntPtr.Zero)
				id_setCursorDrawable_I = JNIEnv.GetMethodID (class_ref, "setCursorDrawable", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCursorDrawable_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCursorDrawable", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEllipsize_Z;
#pragma warning disable 0169
		static Delegate GetSetEllipsize_ZHandler ()
		{
			if (cb_setEllipsize_Z == null)
				cb_setEllipsize_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEllipsize_Z);
			return cb_setEllipsize_Z;
		}

		static void n_SetEllipsize_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEllipsize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEllipsize_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setEllipsize' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEllipsize", "(Z)V", "GetSetEllipsize_ZHandler")]
		public virtual unsafe void SetEllipsize (bool p0)
		{
			if (id_setEllipsize_Z == IntPtr.Zero)
				id_setEllipsize_Z = JNIEnv.GetMethodID (class_ref, "setEllipsize", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEllipsize_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEllipsize", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHint_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetHint_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setHint_Ljava_lang_CharSequence_ == null)
				cb_setHint_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHint_Ljava_lang_CharSequence_);
			return cb_setHint_Ljava_lang_CharSequence_;
		}

		static void n_SetHint_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHint (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHint_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setHint' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setHint", "(Ljava/lang/CharSequence;)V", "GetSetHint_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetHint (global::Java.Lang.ICharSequence p0)
		{
			if (id_setHint_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setHint_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setHint", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHint_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHint", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void SetHint (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetHint (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setHintTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetHintTextColor_IHandler ()
		{
			if (cb_setHintTextColor_I == null)
				cb_setHintTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHintTextColor_I);
			return cb_setHintTextColor_I;
		}

		static void n_SetHintTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHintTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHintTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setHintTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHintTextColor", "(I)V", "GetSetHintTextColor_IHandler")]
		public virtual unsafe void SetHintTextColor (int p0)
		{
			if (id_setHintTextColor_I == IntPtr.Zero)
				id_setHintTextColor_I = JNIEnv.GetMethodID (class_ref, "setHintTextColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHintTextColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHintTextColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMenuItem_Landroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetSetMenuItem_Landroid_view_MenuItem_Handler ()
		{
			if (cb_setMenuItem_Landroid_view_MenuItem_ == null)
				cb_setMenuItem_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMenuItem_Landroid_view_MenuItem_);
			return cb_setMenuItem_Landroid_view_MenuItem_;
		}

		static void n_SetMenuItem_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem p0 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMenuItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItem_Landroid_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setMenuItem' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
		[Register ("setMenuItem", "(Landroid/view/MenuItem;)V", "GetSetMenuItem_Landroid_view_MenuItem_Handler")]
		public virtual unsafe void SetMenuItem (global::Android.Views.IMenuItem p0)
		{
			if (id_setMenuItem_Landroid_view_MenuItem_ == IntPtr.Zero)
				id_setMenuItem_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "setMenuItem", "(Landroid/view/MenuItem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItem_Landroid_view_MenuItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItem", "(Landroid/view/MenuItem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler ()
		{
			if (cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == null)
				cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_);
			return cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
		}

		static void n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemClickListener p0 = (global::Android.Widget.AdapterView.IOnItemClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setOnItemClickListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemClickListener']]"
		[Register ("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", "GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler")]
		public virtual unsafe void SetOnItemClickListener (global::Android.Widget.AdapterView.IOnItemClickListener p0)
		{
			if (id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == IntPtr.Zero)
				id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_;
#pragma warning disable 0169
		static Delegate GetSetOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_Handler ()
		{
			if (cb_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_ == null)
				cb_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_);
			return cb_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_;
		}

		static void n_SetOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener p0 = (global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener)global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnQueryTextListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setOnQueryTextListener' and count(parameter)=1 and parameter[1][@type='com.materialsearchview.MaterialSearchView.OnQueryTextListener']]"
		[Register ("setOnQueryTextListener", "(Lcom/materialsearchview/MaterialSearchView$OnQueryTextListener;)V", "GetSetOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_Handler")]
		public virtual unsafe void SetOnQueryTextListener (global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener p0)
		{
			if (id_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_ == IntPtr.Zero)
				id_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_ = JNIEnv.GetMethodID (class_ref, "setOnQueryTextListener", "(Lcom/materialsearchview/MaterialSearchView$OnQueryTextListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnQueryTextListener_Lcom_materialsearchview_MaterialSearchView_OnQueryTextListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnQueryTextListener", "(Lcom/materialsearchview/MaterialSearchView$OnQueryTextListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_Handler ()
		{
			if (cb_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_ == null)
				cb_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_);
			return cb_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_;
		}

		static void n_SetOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener p0 = (global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener)global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSearchViewListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setOnSearchViewListener' and count(parameter)=1 and parameter[1][@type='com.materialsearchview.MaterialSearchView.SearchViewListener']]"
		[Register ("setOnSearchViewListener", "(Lcom/materialsearchview/MaterialSearchView$SearchViewListener;)V", "GetSetOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_Handler")]
		public virtual unsafe void SetOnSearchViewListener (global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener p0)
		{
			if (id_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_ == IntPtr.Zero)
				id_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_ = JNIEnv.GetMethodID (class_ref, "setOnSearchViewListener", "(Lcom/materialsearchview/MaterialSearchView$SearchViewListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSearchViewListener_Lcom_materialsearchview_MaterialSearchView_SearchViewListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSearchViewListener", "(Lcom/materialsearchview/MaterialSearchView$SearchViewListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setQuery_Ljava_lang_CharSequence_Z;
#pragma warning disable 0169
		static Delegate GetSetQuery_Ljava_lang_CharSequence_ZHandler ()
		{
			if (cb_setQuery_Ljava_lang_CharSequence_Z == null)
				cb_setQuery_Ljava_lang_CharSequence_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetQuery_Ljava_lang_CharSequence_Z);
			return cb_setQuery_Ljava_lang_CharSequence_Z;
		}

		static void n_SetQuery_Ljava_lang_CharSequence_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetQuery (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setQuery_Ljava_lang_CharSequence_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setQuery' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='boolean']]"
		[Register ("setQuery", "(Ljava/lang/CharSequence;Z)V", "GetSetQuery_Ljava_lang_CharSequence_ZHandler")]
		public virtual unsafe void SetQuery (global::Java.Lang.ICharSequence p0, bool p1)
		{
			if (id_setQuery_Ljava_lang_CharSequence_Z == IntPtr.Zero)
				id_setQuery_Ljava_lang_CharSequence_Z = JNIEnv.GetMethodID (class_ref, "setQuery", "(Ljava/lang/CharSequence;Z)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuery_Ljava_lang_CharSequence_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuery", "(Ljava/lang/CharSequence;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void SetQuery (string p0, bool p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetQuery (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setSubmitOnClick_Z;
#pragma warning disable 0169
		static Delegate GetSetSubmitOnClick_ZHandler ()
		{
			if (cb_setSubmitOnClick_Z == null)
				cb_setSubmitOnClick_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSubmitOnClick_Z);
			return cb_setSubmitOnClick_Z;
		}

		static void n_SetSubmitOnClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSubmitOnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSubmitOnClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setSubmitOnClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSubmitOnClick", "(Z)V", "GetSetSubmitOnClick_ZHandler")]
		public virtual unsafe void SetSubmitOnClick (bool p0)
		{
			if (id_setSubmitOnClick_Z == IntPtr.Zero)
				id_setSubmitOnClick_Z = JNIEnv.GetMethodID (class_ref, "setSubmitOnClick", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubmitOnClick_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubmitOnClick", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSuggestionBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSuggestionBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSuggestionBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSuggestionBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuggestionBackground_Landroid_graphics_drawable_Drawable_);
			return cb_setSuggestionBackground_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetSuggestionBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSuggestionBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSuggestionBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setSuggestionBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setSuggestionBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSuggestionBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetSuggestionBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setSuggestionBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setSuggestionBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setSuggestionBackground", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuggestionBackground_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuggestionBackground", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSuggestionIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSuggestionIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSuggestionIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSuggestionIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuggestionIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setSuggestionIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetSuggestionIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSuggestionIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSuggestionIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setSuggestionIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setSuggestionIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSuggestionIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetSuggestionIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setSuggestionIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setSuggestionIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setSuggestionIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuggestionIcon_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuggestionIcon", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSuggestions_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSuggestions_arrayLjava_lang_String_Handler ()
		{
			if (cb_setSuggestions_arrayLjava_lang_String_ == null)
				cb_setSuggestions_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuggestions_arrayLjava_lang_String_);
			return cb_setSuggestions_arrayLjava_lang_String_;
		}

		static void n_SetSuggestions_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetSuggestions (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSuggestions_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setSuggestions' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setSuggestions", "([Ljava/lang/String;)V", "GetSetSuggestions_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetSuggestions (string[] p0)
		{
			if (id_setSuggestions_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setSuggestions_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSuggestions", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuggestions_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuggestions", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
		public virtual unsafe void SetTextColor (int p0)
		{
			if (id_setTextColor_I == IntPtr.Zero)
				id_setTextColor_I = JNIEnv.GetMethodID (class_ref, "setTextColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVoiceIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetVoiceIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setVoiceIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setVoiceIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVoiceIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setVoiceIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetVoiceIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVoiceIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVoiceIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setVoiceIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setVoiceIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetVoiceIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetVoiceIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setVoiceIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setVoiceIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setVoiceIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVoiceIcon_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVoiceIcon", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVoiceSearch_Z;
#pragma warning disable 0169
		static Delegate GetSetVoiceSearch_ZHandler ()
		{
			if (cb_setVoiceSearch_Z == null)
				cb_setVoiceSearch_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVoiceSearch_Z);
			return cb_setVoiceSearch_Z;
		}

		static void n_SetVoiceSearch_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVoiceSearch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVoiceSearch_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='setVoiceSearch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setVoiceSearch", "(Z)V", "GetSetVoiceSearch_ZHandler")]
		public virtual unsafe void SetVoiceSearch (bool p0)
		{
			if (id_setVoiceSearch_Z == IntPtr.Zero)
				id_setVoiceSearch_Z = JNIEnv.GetMethodID (class_ref, "setVoiceSearch", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVoiceSearch_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVoiceSearch", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showKeyboard_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetShowKeyboard_Landroid_view_View_Handler ()
		{
			if (cb_showKeyboard_Landroid_view_View_ == null)
				cb_showKeyboard_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowKeyboard_Landroid_view_View_);
			return cb_showKeyboard_Landroid_view_View_;
		}

		static void n_ShowKeyboard_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowKeyboard (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showKeyboard_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='showKeyboard' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("showKeyboard", "(Landroid/view/View;)V", "GetShowKeyboard_Landroid_view_View_Handler")]
		public virtual unsafe void ShowKeyboard (global::Android.Views.View p0)
		{
			if (id_showKeyboard_Landroid_view_View_ == IntPtr.Zero)
				id_showKeyboard_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "showKeyboard", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showKeyboard_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showKeyboard", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showSearch;
#pragma warning disable 0169
		static Delegate GetShowSearchHandler ()
		{
			if (cb_showSearch == null)
				cb_showSearch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowSearch);
			return cb_showSearch;
		}

		static void n_ShowSearch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSearch ();
		}
#pragma warning restore 0169

		static IntPtr id_showSearch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='showSearch' and count(parameter)=0]"
		[Register ("showSearch", "()V", "GetShowSearchHandler")]
		public virtual unsafe void ShowSearch ()
		{
			if (id_showSearch == IntPtr.Zero)
				id_showSearch = JNIEnv.GetMethodID (class_ref, "showSearch", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSearch);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSearch", "()V"));
			} finally {
			}
		}

		static Delegate cb_showSearch_Z;
#pragma warning disable 0169
		static Delegate GetShowSearch_ZHandler ()
		{
			if (cb_showSearch_Z == null)
				cb_showSearch_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowSearch_Z);
			return cb_showSearch_Z;
		}

		static void n_ShowSearch_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSearch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showSearch_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='showSearch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showSearch", "(Z)V", "GetShowSearch_ZHandler")]
		public virtual unsafe void ShowSearch (bool p0)
		{
			if (id_showSearch_Z == IntPtr.Zero)
				id_showSearch_Z = JNIEnv.GetMethodID (class_ref, "showSearch", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSearch_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSearch", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showSuggestions;
#pragma warning disable 0169
		static Delegate GetShowSuggestionsHandler ()
		{
			if (cb_showSuggestions == null)
				cb_showSuggestions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowSuggestions);
			return cb_showSuggestions;
		}

		static void n_ShowSuggestions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSuggestions ();
		}
#pragma warning restore 0169

		static IntPtr id_showSuggestions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='showSuggestions' and count(parameter)=0]"
		[Register ("showSuggestions", "()V", "GetShowSuggestionsHandler")]
		public virtual unsafe void ShowSuggestions ()
		{
			if (id_showSuggestions == IntPtr.Zero)
				id_showSuggestions = JNIEnv.GetMethodID (class_ref, "showSuggestions", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSuggestions);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSuggestions", "()V"));
			} finally {
			}
		}

		static Delegate cb_showVoice_Z;
#pragma warning disable 0169
		static Delegate GetShowVoice_ZHandler ()
		{
			if (cb_showVoice_Z == null)
				cb_showVoice_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowVoice_Z);
			return cb_showVoice_Z;
		}

		static void n_ShowVoice_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Materialsearchview.MaterialSearchView __this = global::Java.Lang.Object.GetObject<global::Com.Materialsearchview.MaterialSearchView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVoice (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showVoice_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.materialsearchview']/class[@name='MaterialSearchView']/method[@name='showVoice' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showVoice", "(Z)V", "GetShowVoice_ZHandler")]
		public virtual unsafe void ShowVoice (bool p0)
		{
			if (id_showVoice_Z == IntPtr.Zero)
				id_showVoice_Z = JNIEnv.GetMethodID (class_ref, "showVoice", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVoice_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showVoice", "(Z)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener"
		public event EventHandler<global::Com.Materialsearchview.MaterialSearchView.QueryTextChangeEventArgs> QueryTextChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener, global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor>(
						ref weak_implementor_SetOnQueryTextListener,
						__CreateIOnQueryTextListenerImplementor,
						SetOnQueryTextListener,
						__h => __h.OnQueryTextChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener, global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor>(
						ref weak_implementor_SetOnQueryTextListener,
						global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor.__IsEmpty,
						__v => SetOnQueryTextListener (null),
						__h => __h.OnQueryTextChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Materialsearchview.MaterialSearchView.QueryTextSubmitEventArgs> QueryTextSubmit {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener, global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor>(
						ref weak_implementor_SetOnQueryTextListener,
						__CreateIOnQueryTextListenerImplementor,
						SetOnQueryTextListener,
						__h => __h.OnQueryTextSubmitHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListener, global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor>(
						ref weak_implementor_SetOnQueryTextListener,
						global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor.__IsEmpty,
						__v => SetOnQueryTextListener (null),
						__h => __h.OnQueryTextSubmitHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnQueryTextListener;

		global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor __CreateIOnQueryTextListenerImplementor ()
		{
			return new global::Com.Materialsearchview.MaterialSearchView.IOnQueryTextListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Materialsearchview.MaterialSearchView.ISearchViewListener"
		public event EventHandler SearchViewClosed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener, global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor>(
						ref weak_implementor_SetOnSearchViewListener,
						__CreateISearchViewListenerImplementor,
						SetOnSearchViewListener,
						__h => __h.OnSearchViewClosedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener, global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor>(
						ref weak_implementor_SetOnSearchViewListener,
						global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor.__IsEmpty,
						__v => SetOnSearchViewListener (null),
						__h => __h.OnSearchViewClosedHandler -= value);
			}
		}

		public event EventHandler SearchViewShown {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener, global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor>(
						ref weak_implementor_SetOnSearchViewListener,
						__CreateISearchViewListenerImplementor,
						SetOnSearchViewListener,
						__h => __h.OnSearchViewShownHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Materialsearchview.MaterialSearchView.ISearchViewListener, global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor>(
						ref weak_implementor_SetOnSearchViewListener,
						global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor.__IsEmpty,
						__v => SetOnSearchViewListener (null),
						__h => __h.OnSearchViewShownHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSearchViewListener;

		global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor __CreateISearchViewListenerImplementor ()
		{
			return new global::Com.Materialsearchview.MaterialSearchView.ISearchViewListenerImplementor (this);
		}
#endregion
	}
}
