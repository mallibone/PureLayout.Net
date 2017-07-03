![NuGet Version](https://img.shields.io/nuget/v/PureLayout.Net.svg) ![License](https://img.shields.io/badge/License-MIT-blue.svg)
# PureLayout.Net

The ultimate layouting API for iOS is now available for Xamarin.iOS. <a href="https://github.com/PureLayout/PureLayout" target="_blank">PureLayout</a> extends `UIView`/`NSView`, `NSArray`, and `NSLayoutConstraint` and brings productivity boosting enhancements with a refined Auto Layout API that is modeled after Apple's own frameworks. PureLayout.Net brings you 100% of the cross-platform Objective-C library to C# with Xamarin.iOS.

Writing your responsive iOS UIs in code behind can be a challenge when only using vanilla Auto Layout code. PureLayout.Net brings a developer-friendly approach for defining interface based on Auto Layout. Basing your UI code on PureLayout.Net will enable you and your team to write modularized view code which is designed for optimum performance and design flexibility.0

### Table of Contents
1. [Setup](#setup)
1. [API](#api)
1. [Usage](#usage)
    * [Sample Code](#sample-code-swift)
1. [Building it from scratch](#building-it-from-scratch)
 
 ## Setup
 
To start out using PureLayout.Net in your Xamarin.iOS project simply install the following NuGet package:

```powershell
Install-Package PureLayout.Net
```

The library is compiled for use with the simulator and iOS devices with an ARMv7(s) or ARM64.
  
 ## PureLayout.Net 101
 
 Sample Project Coming soon
 PureLayout allows you to define your iOS UI in directly in C#/F#. This will not only make the UI code easier to maintain and use, but also allows to swiftly define layouting constraints. For example the following UI:
 
 IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
 
 Was developed with the following constraints:
 
```csharp
public override void ViewWillAppear(bool animated)
{
    base.ViewWillAppear(animated);
    View.BackgroundColor = UIColor.White;

    var amount = new UITextField {KeyboardType = UIKeyboardType.DecimalPad, Placeholder = "Total Amount", BorderStyle = UITextBorderStyle.RoundedRect};
    var tipPercentage = new UITextField {KeyboardType = UIKeyboardType.DecimalPad, Text = "10.0", BorderStyle = UITextBorderStyle.RoundedRect};
    var calculateButton = new UIButton(UIButtonType.RoundedRect);
    calculateButton.SetTitle("Calculate Tip", UIControlState.Normal);
    var tableView = new UITableView();
    var clearHistoryButton = new UIButton(UIButtonType.RoundedRect);
    clearHistoryButton.SetTitle("Clear History", UIControlState.Normal);
    clearHistoryButton.BackgroundColor = UIColor.FromRGB(243, 105, 105);
    clearHistoryButton.SetTitleColor(UIColor.White, UIControlState.Normal);

    View.Add(amount);
    View.Add(tipPercentage);
    View.Add(calculateButton);
    View.Add(tableView);
    View.Add(clearHistoryButton);

    amount.AutoPinEdgeToSuperviewEdge(ALEdge.Top, Constants.WideMargin);
    amount.AutoPinEdgeToSuperviewEdge(ALEdge.Left, Constants.DefaultMargin);
    amount.AutoPinEdge(ALEdge.Trailing, ALEdge.Leading, tipPercentage, -Constants.DefaultMargin);

    tipPercentage.AutoPinEdgeToSuperviewEdge(ALEdge.Right, Constants.DefaultMargin);
    tipPercentage.AutoAlignAxis(ALAxis.Horizontal, amount);

    calculateButton.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, amount, Constants.DefaultMargin);
    calculateButton.AutoAlignAxisToSuperviewAxis(ALAxis.Vertical);

    tableView.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, calculateButton, Constants.WideMargin);
    tableView.AutoPinEdgeToSuperviewEdge(ALEdge.Leading, Constants.DefaultMargin);
    tableView.AutoPinEdgeToSuperviewEdge(ALEdge.Trailing, Constants.DefaultMargin);
    tableView.AutoPinEdge(ALEdge.Bottom, ALEdge.Top, clearHistoryButton);

    clearHistoryButton.AutoPinEdgesToSuperviewEdgesExcludingEdge(ALEdge.Top);
    clearHistoryButton.AutoSetDimension(ALDimension.Height, Constants.WideMargin * 2);
    clearHistoryButton.AutoPinEdge(ALEdge.Top,ALEdge.Bottom, tableView);
}
```

 While PureLayout can play along very nicely with existing Storyboard layouts and can be used for simply adding or editing layout definitions it allows you to define your UI in a modularized, shareable and scaleable fashion. To create a Xamarin.iOS project without using a storyboard follow the instructions on this page of the <a href="https://developer.xamarin.com/guides/ios/application_fundamentals/ios_code_only/" target="_blank">Xamarin Developer guide</a>.
 
 
 ## API Reference
 
 Coming soon

## Building PureLayout.Net from scratch

Coming soon

## Thank you

A big thank you towards Tyler Fox (<a href="https://github.com/smileyborg" target="_blank">@smileyborg</a>) the original creator of <a href="https://github.com/PureLayout/PureLayout" target="_blank">PureLayout</a> and Mickey Reiss (<a href="https://github.com/mickeyreiss" target="_blank">@mickeyreiss</a>) current maintainer of the project for bringing this library to the iOS community.