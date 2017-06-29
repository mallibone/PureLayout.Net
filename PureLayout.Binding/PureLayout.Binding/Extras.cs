using System;
using UIKit;

namespace PureLayout.Net
{
    public partial class UIViewPureLayout
    {
        public static NSLayoutConstraint[] AutoPinEdgesToSuperviewEdgesExcludingEdge(this UIView view, ALEdge excludingEdge)
        {
            return view.AutoPinEdgesToSuperviewEdgesExcludingEdge(ALHelpers.ALEdgeInsetsZero, excludingEdge);
        }

	}
}
