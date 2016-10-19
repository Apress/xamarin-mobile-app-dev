﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LayoutAndroidExample
{
    [Activity(Label = "GridMultiCellActivity", MainLauncher = false, Icon = "@drawable/icon")]
	public class GridMultiCellActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			RequestWindowFeature(WindowFeatures.NoTitle);
			base.OnCreate (bundle);

            SetContentView(Resource.Layout.GridLayoutMultiCellView);

		}


	}
}


