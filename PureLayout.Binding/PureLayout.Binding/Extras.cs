using System;
using UIKit;

namespace PureLayout.Net
{
    public static partial class UIViewPureLayout
    {
        public static NSLayoutConstraint[] AutoPinEdgesToSuperviewEdgesExcludingEdge(this UIView view, ALEdge excludingEdge)
        {
            return view.AutoPinEdgesToSuperviewEdgesWithInsets(ALHelpers.ALEdgeInsetsZero, excludingEdge);
        }

        //public static NSLayoutConstraint AutoPinToBottomLayoutGuideOfViewController(this UIView view, UIViewController viewController)
        //{
        //    return view.AutoPinToBottomLayoutGuideOfViewController(viewController, 0f);
        //}

		//public static NSLayoutConstraint AutoPinToTopLayoutGuideOfViewController(this UIView view, UIViewController viewController)
		//{
		//	return view.AutoPinToTopLayoutGuideOfViewController(viewController, 0f);
		//}
	}
}
