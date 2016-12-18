Material SearchView
=====

Version : 1.0.0

Download : Available on Nuget Gallery (https://www.nuget.org/packages/SearchView.Xamarin)

How do I use SearchView ?
-------------------

Simple use cases :

```javascript
<FrameLayout
        android:id="@+id/toolbar_container"
        android:layout_width="match_parent"
        android:layout_height="wrap_content">
        <include
            android:id="@+id/toolbar"
            layout="@layout/layout_toolbar_locations" />
        <com.materialsearchview.MaterialSearchView
            android:id="@+id/search_view"
            android:layout_width="match_parent"
            android:layout_height="wrap_content" />
    </FrameLayout>
```

// Implement Query Text Listener :
```cs
public class LocationsActivity : AppCompatActivity, MaterialSearchView.IOnQueryTextListener
	{
    ...
```

// Override Query Text Listener Methods			 
```cs
	public bool OnQueryTextChange(string p0)
		{
			if (!string.IsNullOrEmpty(p0))
			{
			  // Do something
			}
			return true;
		}

		public bool OnQueryTextSubmit(string p0)
		{
			return false;
		}	     
```

// Implement IOnClickListener  
```cs
public class LocationsActivity : AppCompatActivity, MaterialSearchView.IOnQueryTextListener
	{
    ...
    
public void ItemViewOnClick(View p0, int p1)
		{
			// Do Something, p1 = position
		}
    
```



![alt tag](http://g.recordit.co/pdPddtBOxz.gif)

Author
------
Beray Bentesen -  @BerayBentesen on Twitter




