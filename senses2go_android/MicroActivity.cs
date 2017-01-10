
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
	[Activity(Label = "Mikrofon")]
	public class MicroActivity : Activity
	{
		MediaRecorder recorder;
		MediaPlayer player;
		Button startRec;
		Button playRec;
		bool recording;
		String path;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Micro);
			startRec = FindViewById<Button>(Resource.Id.button1);
			playRec = FindViewById<Button>(Resource.Id.button2);
			playRec.Enabled = false;
			PrepareToRecord();
			PrepareToPlayRecord();
		}

		protected void PrepareToRecord()
		{
			recorder = new MediaRecorder();
			path = "/sdcard/test.3gpp";
			recording = false;
			startRec.Click += delegate
			{
				if (!recording)
				{
					recorder.SetAudioSource(AudioSource.Mic);
					recorder.SetOutputFormat(OutputFormat.ThreeGpp);
					recorder.SetAudioEncoder(AudioEncoder.AmrNb);
					recorder.SetOutputFile(path);
					recorder.Prepare();
					recorder.Start();
					recording = true;
					startRec.Text = "Stop Record";
				}
				else
				{
					recorder.Stop();
					recorder.Reset();
					startRec.Text = "Start Record";
					playRec.Enabled = true;
					recording = false;
				}
			};
		}

		protected void PrepareToPlayRecord()
		{
			player = new MediaPlayer();
			player.Completion += delegate {
				player.Stop();
				playRec.Text = "Play Record";
				player.Reset();
			};
			playRec.Click += delegate
			{
				if (!player.IsPlaying)
				{
					player.SetDataSource(path);
					player.Prepare();
					player.Start();
					playRec.Text = "Pause Record";
				}
				else {
					player.Stop();
					playRec.Text = "Play Record";
				}
			};
		}
	}
}
