using System;
using Foundation;
using UIKit;

namespace PureLayoutSample
{
    [Preserve(AllMembers = true)]
    public class LinkerPleaseInclude
    {
        public void Include(UITextField textField)
        {
            textField.Text = textField.Text + "";
            textField.Placeholder = textField.Placeholder + "";

            textField.EditingChanged += (sender, args) =>
            {
                textField.Text = "";
            };
        }

        public void Include(UIButton uiButton)
        {
            uiButton.TouchUpInside += (s, e) =>
                                      uiButton.SetTitle(uiButton.Title(UIControlState.Normal), UIControlState.Normal);
        }

        public void Include(UILabel label)
        {
            label.Text = label.Text + "";
        }
    }
}
