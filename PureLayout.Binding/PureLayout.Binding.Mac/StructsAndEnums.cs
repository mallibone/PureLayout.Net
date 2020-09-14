using ObjCRuntime;
using AppKit;

namespace PureLayout.Net
{
	[Native]
	public enum ALEdge : long
	{
		Left = NSLayoutAttribute.Left,
		Right = NSLayoutAttribute.Right,
		Top = NSLayoutAttribute.Top,
		Bottom = NSLayoutAttribute.Bottom,
		Leading = NSLayoutAttribute.Leading,
		Trailing = NSLayoutAttribute.Trailing
	}

	[Native]
	public enum ALDimension : long
	{
		Width = NSLayoutAttribute.Width,
		Height = NSLayoutAttribute.Height
	}

	[Native]
	public enum ALAxis : long
	{
		Vertical = NSLayoutAttribute.CenterX,
		Horizontal = NSLayoutAttribute.CenterY,
		Baseline = NSLayoutAttribute.Baseline,
		LastBaseline = Baseline
	}

	[Native]
	public enum ALAttribute : long
	{
		Left = ALEdge.Left,
		Right = ALEdge.Right,
		Top = ALEdge.Top,
		Bottom = ALEdge.Bottom,
		Leading = ALEdge.Leading,
		Trailing = ALEdge.Trailing,
		Width = ALDimension.Width,
		Height = ALDimension.Height,
		Vertical = ALAxis.Vertical,
		Horizontal = ALAxis.Horizontal,
		Baseline = ALAxis.Baseline,
		LastBaseline = ALAxis.LastBaseline
	}
}
