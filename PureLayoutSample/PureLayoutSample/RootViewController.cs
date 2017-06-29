﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PureLayout.Net;
using UIKit;

namespace PureLayoutSample
{
    class RootViewController : UIViewController
    {
        private UITextField _amount;
        private UITextField _tipPercentage;
        private UIButton _calculateButton;

        public RootViewController()
        {
        }
        public RootViewController(IntPtr handler):base(handler)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            View.BackgroundColor = UIColor.White;


            //var labelTipUnit
            _amount = new UITextField {KeyboardType = UIKeyboardType.DecimalPad, Placeholder = "Total Amount", BorderStyle = UITextBorderStyle.RoundedRect};
            _tipPercentage = new UITextField {KeyboardType = UIKeyboardType.DecimalPad, Text = "10.0", BorderStyle = UITextBorderStyle.RoundedRect};
            _calculateButton = new UIButton(UIButtonType.RoundedRect);
            _calculateButton.SetTitle("Calculate Tip", UIControlState.Normal);
            var scrollView = new UIScrollView();
            var tableView = new UITableView();
            var clearHistoryButton = new UIButton(UIButtonType.RoundedRect);
			clearHistoryButton.SetTitle("Clear History", UIControlState.Normal);
            clearHistoryButton.BackgroundColor = UIColor.FromRGB(243, 105, 105);
            clearHistoryButton.SetTitleColor(UIColor.White, UIControlState.Normal);

			View.Add(_amount);
            View.Add(_tipPercentage);
            View.Add(_calculateButton);
			View.Add(tableView);
            View.Add(clearHistoryButton);

			_amount.AutoPinEdgeToSuperviewEdge(ALEdge.Top, Constants.WideMargin);
            _amount.AutoPinEdgeToSuperviewEdge(ALEdge.Left, Constants.DefaultMargin);
            _amount.AutoPinEdge(ALEdge.Trailing, ALEdge.Leading, _tipPercentage, -Constants.DefaultMargin);

            _tipPercentage.AutoPinEdgeToSuperviewEdge(ALEdge.Right, Constants.DefaultMargin);
            _tipPercentage.AutoAlignAxis(ALAxis.Horizontal, _amount);

            _calculateButton.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, _amount, Constants.DefaultMargin);
            _calculateButton.AutoAlignAxisToSuperviewAxis(ALAxis.Vertical);

            tableView.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, _calculateButton, Constants.WideMargin);
            tableView.AutoPinEdgeToSuperviewEdge(ALEdge.Leading, Constants.DefaultMargin);
            tableView.AutoPinEdgeToSuperviewEdge(ALEdge.Trailing, Constants.DefaultMargin);
            tableView.AutoPinEdge(ALEdge.Bottom, ALEdge.Top, clearHistoryButton);

            clearHistoryButton.AutoPinEdgesToSuperviewEdgesExcludingEdge(ALEdge.Top);
			clearHistoryButton.AutoSetDimension(ALDimension.Height, Constants.WideMargin * 2);
			clearHistoryButton.AutoPinEdge(ALEdge.Top,ALEdge.Bottom, tableView);
		}
    }

    public static class Constants
    {
        public const long TightMargin = DefaultMargin / 2;
        public const long DefaultMargin = 16;
        public const long WideMargin = DefaultMargin * 2;
    }
}