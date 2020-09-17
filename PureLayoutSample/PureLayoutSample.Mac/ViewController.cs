using System;

using AppKit;
using Foundation;

using PureLayout.Net;

namespace PureLayoutSample.Mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            var button = new NSButton();
            View.AddSubview(button);

            button.AutoPinEdgesToSuperviewEdgesWithInsets(new NSEdgeInsets(50, 50, 50, 50));
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
