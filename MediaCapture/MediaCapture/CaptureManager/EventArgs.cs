//
// how to capture still images, video and audio using iOS AVFoundation and the AVCAptureSession
//
// This sample handles all of the low-level AVFoundation and capture graph setup required to capture and save media.  This code also exposes the
// capture, configuration and notification capabilities in a more '.Netish' way of programming.  The client code will not need to deal with threads, delegate classes
// buffer management, or objective-C data types but instead will create .NET objects and handle standard .NET events.  The underlying iOS concepts and classes are detailed in
// the iOS developer online help (TP40010188-CH5-SW2).
//
// https://developer.apple.com/library/mac/#documentation/AudioVideo/Conceptual/AVFoundationPG/Articles/04_MediaCapture.html#//apple_ref/doc/uid/TP40010188-CH5-SW2
//
// Enhancements, suggestions and bug reports can be sent to steve.millar@infinitekdev.com
//
using System;
using UIKit;
using Foundation;

namespace MediaCapture
{
	public class MovieSegmentRecordingStartedEventArgs : EventArgs
	{
		public string Path { get; set; }
	}

	public class MovieSegmentRecordingCompleteEventArgs : EventArgs
	{
		public string Path { get; set; }
		public int Length { get; set; }
		public bool ErrorOccured { get; set; }
	}

	public class MovieSegmentCapturedEventArgs : EventArgs
	{
		public DateTime StartedAt { get; set; }
		public int DurationMilliSeconds { get; set; }
		public string File { get; set; }
	}

	public class CaptureErrorEventArgs : EventArgs
	{
		public string ErrorMessage { get; set; }
	}

	public class ImageCaptureEventArgs : EventArgs
	{
		public UIImage Image { get; set; }
		public DateTime CapturedAt { get; set; }
	}
}