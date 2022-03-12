using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Xamarin.YandexAds.iOS
{
	[Native]
	public enum YMADeliveryMethod : ulong
	{
		Unknown,
		Streaming,
		Progressive
	}

	[Native]
	public enum YMANativeAdType : long
	{
		Content,
		AppInstall,
		Media
	}

	[Flags]
	[Native]
	public enum YMADeviceType : ulong
	{
		None = 0x0,
		Hardware = 1uL << 0,
		Simulator = 1uL << 1
	}

	[Native]
	public enum YMAVMAPErrorCode : long
	{
		YMAVMAPErrorCodeInvalidXMLResponse
	}

	[Native]
	public enum YMAVASTAdType : ulong
	{
		Unknown,
		InLine,
		Wrapper
	}

	[Native]
	public enum YMAAdErrorCode : long
	{
		EmptyBlockID,
		InvalidUUID,
		NoSuchBlockID,
		NoFill,
		BadServerResponse,
		AdSizeMismatch,
		AdTypeMismatch,
		ServiceTemporarilyNotAvailable,
		AdHasAlreadyBeenPresented,
		NilPresentingViewController,
		IncorrectFullscreenView
	}

	[Native]
	public enum YMAVASTErrorCode : long
	{
		NoAdsInVASTResponse,
		InvalidXMLResponse,
		CannotBuildRequest
	}

	[Native]
	public enum YMAVASTIconResourceType : ulong
	{
		Unknown,
		Static,
		IFrame,
		Html
	}

	[Native]
	public enum YMAVASTIconHorizontalPosition : ulong
	{
		Left,
		Right,
		LeftOffset
	}

	[Native]
	public enum YMAVASTIconVerticalPosition : ulong
	{
		Top,
		Bottom,
		TopOffset
	}

	[Native]
	public enum YMANativeErrorCode : long
	{
		NoViewForAsset,
		InvalidViewForBinding
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct YMAHorizontalOffset
	{
		public nfloat left;

		public nfloat right;
	}

	[Native]
	public enum YMASizeConstraintType : long
	{
		Fixed,
		FixedBannerRatio,
		PreferredBannerRatio
	}
}