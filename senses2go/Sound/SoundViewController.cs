using System;

using UIKit;
using AVFoundation;
using Foundation;
using AudioToolbox;

namespace senses2go
{
	public partial class SoundViewController : UIViewController
	{
		private AVAudioPlayer player;

		public SoundViewController() : base("SoundViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Lautsprecher";
		}

		partial void play(UIButton sender)
		{
			if (player != null && player.Playing)
			{
				player.Pause();
				this.playButton.SetTitle("Play", UIControlState.Normal);
			}
			else {
				var mp3File = "Sound/sounds/guitar.mp3";
				var mp3URL = new NSUrl(mp3File);
				Console.WriteLine(mp3URL.AbsoluteUrl);
				var mp3 = AudioToolbox.AudioSource.Open(mp3URL, AudioFilePermission.Read, AudioFileType.MP3);
				if (mp3 != null)
				{
					Console.WriteLine(mp3.EstimatedDuration);
					player = AVAudioPlayer.FromUrl(mp3URL);
					player.Play();
					this.playButton.SetTitle("Pause", UIControlState.Normal);
				}
				else {
					Console.WriteLine("File could not be loaded: {0}", mp3URL.FilePathUrl);
				}
			}
		}

	}
}

