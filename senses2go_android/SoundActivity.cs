
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace senses2go_android
{
	[Activity(Label = "Lautsprecher")]
	public class SoundActivity : Activity
	{
		MediaPlayer player;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Sound);
			player = MediaPlayer.Create(this, Resource.Raw.guitar);
			FindViewById<Button>(Resource.Id.button1).Click += delegate {
				if (player.IsPlaying)
				{
					player.Pause();
					FindViewById<Button>(Resource.Id.button1).Text = "Play";
				}
				else
				{
					player.Start();
					FindViewById<Button>(Resource.Id.button1).Text = "Pause";
				}
			};
		}

		protected override void OnPause()
		{
			base.OnPause();
			player.Stop();
		}
	}
}
