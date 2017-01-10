using System;
using System.IO;

using UIKit;
using AVFoundation;
using Foundation;
using AudioToolbox;

namespace senses2go
{
	public partial class MicroViewController : UIViewController
	{
		AVAudioRecorder recorder;
		NSError error;
		NSUrl url;
		NSDictionary settings;
		bool recording;
		String audioFilePath;

		private AVAudioPlayer player;

		public MicroViewController() : base("MicroViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Mikrofon";
			PrepareToRecord();

		}

		protected void PrepareToRecord()
		{
			var audioSession = AVAudioSession.SharedInstance();
			var err = audioSession.SetCategory(AVAudioSessionCategory.PlayAndRecord);
			if (err != null)
			{
				Console.WriteLine("audioSession: {0}", err);
			}
			err = audioSession.SetActive(true);
			if (err != null)
			{
				Console.WriteLine("audioSession: {0}", err);
			}

			//Declare string for application temp path and tack on the file extension
			string fileName = string.Format("Myfile{0}.wav", DateTime.Now.ToString("yyyyMMddHHmmss"));
			audioFilePath = System.IO.Path.GetTempPath() + fileName;

			Console.WriteLine("Audio File Path: " + audioFilePath);

			url = NSUrl.FromFilename(audioFilePath);
			//set up the NSObject Array of values that will be combined with the keys to make the NSDictionary
			NSObject[] values = new NSObject[]
			{
				NSNumber.FromFloat (44100.0f), //Sample Rate
			    NSNumber.FromInt32 ((int)AudioToolbox.AudioFormatType.LinearPCM), //AVFormat
			    NSNumber.FromInt32 (2), //Channels
			    NSNumber.FromInt32 (16), //PCMBitDepth
			    NSNumber.FromBoolean (false), //IsBigEndianKey
			    NSNumber.FromBoolean (false) //IsFloatKey
			};

			//Set up the NSObject Array of keys that will be combined with the values to make the NSDictionary
			NSObject[] keys = new NSObject[]
			{
				AVAudioSettings.AVSampleRateKey,
				AVAudioSettings.AVFormatIDKey,
				AVAudioSettings.AVNumberOfChannelsKey,
				AVAudioSettings.AVLinearPCMBitDepthKey,
				AVAudioSettings.AVLinearPCMIsBigEndianKey,
				AVAudioSettings.AVLinearPCMIsFloatKey
			};

			//Set Settings with the Values and Keys to create the NSDictionary
			settings = NSDictionary.FromObjectsAndKeys(values, keys);

			//Set recorder parameters
			recorder = AVAudioRecorder.Create(url, new AudioSettings(settings), out error);

			//Set Recorder to Prepare To Record
			recorder.PrepareToRecord();

			recording = false;
		}

		partial void record(UIButton sender)
		{
			if (!recording)
			{
				recorder.Record();
				this.recButton.SetTitle("rec..", UIControlState.Normal);
				this.recButton.BackgroundColor = UIColor.Red;
				recording = true;
			}
			else {
				recorder.Stop();
				this.recButton.SetTitle("Start", UIControlState.Normal);
				this.recButton.BackgroundColor = UIColor.Blue;
				this.playButton.Enabled = true;
				recording = false;
			}
		}

		partial void play(UIButton sender)
		{
			if (!recording)
			{;
				var wavURL = new NSUrl(audioFilePath);
				Console.WriteLine(wavURL.AbsoluteUrl);
				var wav = AudioToolbox.AudioSource.Open(wavURL, AudioFilePermission.Read, AudioFileType.WAVE);
				if (wav != null)
				{
					Console.WriteLine(wav.EstimatedDuration);
					player = AVAudioPlayer.FromUrl(wavURL);
					player.Play();
				}
			}

		}
	}
}

