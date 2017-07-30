[![NuGet Version](https://img.shields.io/nuget/v/PureLayout.Net.svg)](https://www.nuget.org/packages/PureLayout.Net/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)
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
 
 PureLayout allows you to define your iOS UI in directly in C#/F#. This will not only make the UI code easier to maintain and use, but also allows to swiftly define layouting constraints. After installing the NuGet package, you can add the following using line to the class you want to start layouting your UI:
 
 ```csharp
somethingThatDerivesFromUIView.AutoPinEdgesToSuperview();
```
 
All the PureLayout constraints start with `Auto[XYZ]`. Keep that in mind when you are looking for a constraint to apply. Defining a constraint is as easy as the following line:
 
 ```csharp
somethingThatDerivesFromUIView.AutoPinEdgesToSuperview();
```

So for the follwing UI:
 
 ![showing the rendered sample code bellow](https://github.com/mallibone/PureLayout.Net/blob/master/PureLayoutSample/Images/ScreenShot.png "Sample Layout")
 
 The layouts would look like this:
 
```csharp
private void LayoutView()
{
    View.BackgroundColor = UIColor.White;
    _amountLabel = new UILabel();
    _amountLabel.Text = "Amount: ";
    _amountLabel.Font = UIFont.PreferredBody;

    _tipPercentageLabel = new UILabel();
    _tipPercentageLabel.Text = "Tip %: ";
    _tipPercentageLabel.Font = UIFont.PreferredBody;

    _amount = new UITextField
    {
        KeyboardType = UIKeyboardType.DecimalPad,
        Placeholder = "Total Amount",
        BorderStyle = UITextBorderStyle.RoundedRect
    };

    _tipPercentage = new UITextField
    {
        KeyboardType = UIKeyboardType.DecimalPad,
		Placeholder = "Tip %",
        BorderStyle = UITextBorderStyle.RoundedRect
    };

    _calculateButton = new UIButton(UIButtonType.RoundedRect);
    _calculateButton.SetTitle("Calculate Tip", UIControlState.Normal);
    _tableView = new UITableView();
    _clearHistoryButton = new UIButton(UIButtonType.RoundedRect);
    _clearHistoryButton.SetTitle("Clear History", UIControlState.Normal);
    _clearHistoryButton.BackgroundColor = UIColor.FromRGB(243, 105, 105);
    _clearHistoryButton.SetTitleColor(UIColor.White, UIControlState.Normal);

    View.Add(_amount);
    View.Add(_tipPercentage);
    View.Add(_calculateButton);
    View.Add(_tableView);
    View.Add(_clearHistoryButton);

	_amount.AutoPinEdgeToSuperviewEdge(ALEdge.Top, Constants.WideMargin);
	_amount.AutoPinEdgeToSuperviewEdge(ALEdge.Left, Constants.DefaultMargin);
    _tipPercentage.AutoPinEdge(ALEdge.Leading, ALEdge.Trailing, _amount, Constants.DefaultMargin);
	_tipPercentage.AutoPinEdgeToSuperviewEdge(ALEdge.Right, Constants.DefaultMargin);
    _tipPercentage.AutoAlignAxis(ALAxis.Baseline, _amount);

    _calculateButton.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, _amount, Constants.DefaultMargin);
    _calculateButton.AutoAlignAxisToSuperviewAxis(ALAxis.Vertical);

    _tableView.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, _calculateButton, Constants.WideMargin);
    _tableView.AutoPinEdgeToSuperviewEdge(ALEdge.Leading, Constants.DefaultMargin);
    _tableView.AutoPinEdgeToSuperviewEdge(ALEdge.Trailing, Constants.DefaultMargin);
    _tableView.AutoPinEdge(ALEdge.Bottom, ALEdge.Top, _clearHistoryButton);

    _clearHistoryButton.AutoPinEdgesToSuperviewEdgesExcludingEdge(ALEdge.Top);
    _clearHistoryButton.AutoSetDimension(ALDimension.Height, Constants.WideMargin * 2);
    _clearHistoryButton.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, _tableView);
}

```

 While PureLayout can play along very nicely with existing Storyboard layouts and can be used for simply adding or editing layout definitions it allows you to define your UI in a modularized, shareable and scaleable fashion. To create a Xamarin.iOS project without using a storyboard follow the instructions on this page of the <a href="https://developer.xamarin.com/guides/ios/application_fundamentals/ios_code_only/" target="_blank">Xamarin Developer guide</a>.
 
 
 ## API Reference

PureLayout.Net allows to set the following different kind of constraints via the following attributes that are mapped to Enums in Xamarin:

* `ALEdge`
    * `Top`
    * `Bottom`
    * `Left`
    * `Right`
    * `Leading`
    * `Trailing`
* `ALDimension`
    * `Height`
    * `Width`
* `ALAxis`
    * `Vertical`
    * `Horizontal`
    * `Baseline`
    * `FirstBaseline`
    * `LastBaseline`
* `ALMargin`
    * `Top`
    * `Bottom`
    * `Left`
    * `Right`
    * `Leading`
    * `Trailing`
* `ALMarginAxis`
    * `Horizontal`
    * `Vertical`

As stated on the original PureLayout GitHub repository, the following <a href="https://github.com/PureLayout/PureLayout/blob/master/Images/PureLayout-CommonAttributes.png" target="_blank">picture</a> describes best what kind of constraints can be set on `UIView` Elements.

### Pin Edges
PureLayout lets you pin the edges of a view to it's super view or any adjacent view. Pinning the view to it's super view can be achieved with the following methods:

```csharp
// Prep code
var edgeInsets = new UIEdgeInsets(top: 16, left: 16f, bottom: 16f, right: 16f);
var view = new UIView();

// Pin Edges
view.AutoPinEdgesToSuperviewEdges();
view.AutoPinEdgesToSuperviewEdges(edgeInsets);

// Exclude an Edge
view.AutoPinEdgesToSuperviewEdgesExcludingEdge(excludingEdge: ALEdge.Bottom);
view.AutoPinEdgesToSuperviewEdgesExcludingEdge(insets: edgeInsets, excludingEdge: ALEdge.Bottom);
```
Note that it is possible to either pin all edges or all but one edge to the super view. It is further possible to define the inset with the `UIEdgeInset` object. Alternatively the edges can be pinned to the margins of the super view.

```csharp
view.AutoPinEdgesToSuperviewMargins();

// Exclude an Edge
view.AutoPinEdgesToSuperviewMarginsExcludingEdge(edge: ALEdge.Bottom);
view.AutoPinEdgesToSuperviewMarginsExcludingEdge(insets: edgeInsets, edge: ALEdge.Bottom);
```

It is also possible to pin a single edge to the super view:

```csharp
// Pin Edge to Superview Edge
view.AutoPinEdgeToSuperviewEdge(edge: ALEdge.Top);
view.AutoPinEdgeToSuperviewEdge(edge: ALEdge.Top, inset: 16f);
view.AutoPinEdgeToSuperviewEdge(edge: ALEdge.Top, inset: 16f, relation: NSLayoutRelation.LessThanOrEqual);

// Pin Edge to Supverview Margin
view.AutoPinEdgeToSuperviewMargin(edge: ALEdge.Left);
view.AutoPinEdgeToSuperviewMargin(edge: ALEdge.Left, relation: NSLayoutRelation.GreaterThanOrEqual);
```

Further you can pin an edge of one UIView to the edge of another UIView:

```csharp
view.AutoPinEdge(edge: ALEdge.Right, toEdge: ALEdge.Left, otherView: otherView);
view.AutoPinEdge(edge: ALEdge.Right, toEdge: ALEdge.Left, otherView: otherView, offset: 16f);
view.AutoPinEdge(edge: ALEdge.Right, toEdge: ALEdge.Left, otherView: otherView, offset: 16f, relation: NSLayoutRelation.GreaterThanOrEqual);
```

And if you just simply want to pin a `UIView` to the top or bottom navigation layout just use one of the following options:

```csharp
// Pin to Top Layout
view.AutoPinToTopLayoutGuideOfViewController(viewController: this);
view.AutoPinToTopLayoutGuideOfViewController(viewController: this, inset: 16f);
view.AutoPinToTopLayoutGuideOfViewController(viewController: this, inset: 16f, relation: NSLayoutRelation.Equal);

// Pin to Bottom Layout
view.AutoPinToBottomLayoutGuideOfViewController(viewController: this);
view.AutoPinToBottomLayoutGuideOfViewController(viewController: this, inset: 16f);
view.AutoPinToBottomLayoutGuideOfViewController(viewController: this, inset: 16f, relation: NSLayoutRelation.Equal);
```

### Align and Center
Another common use case when defining a layout is aligning different UI Elements to each other. There by the UI element can either be aligned to the superview:

```csharp
// Align to Superview
view.AutoCenterInSuperview();
view.AutoAlignAxisToSuperviewAxis(axis: ALAxis.Horizontal);

// Align to Supberview margins
view.AutoCenterInSuperviewMargins();
view.AutoAlignAxisToSuperviewMarginAxis(axis: ALAxis.Horizontal);
```


Or in regards to another UI element:

```csharp
view.AutoAlignAxis(axis: ALAxis.Baseline, otherView: otherView);
view.AutoAlignAxis(axis: ALAxis.Baseline, otherView: otherView, offset: 16f);
view.AutoAlignAxis(axis: ALAxis.Baseline, otherView: otherView, offset: 16f, multiplier: 2f);
```

### Set Dimensions
PureLayout allows to either set the dimension to a fixed value:

```csharp
view.AutoSetDimension(dimension: ALDimension.Width, size: 128f);
view.AutoSetDimension(dimension: ALDimension.Width, size: 128f, relation: NSLayoutRelation.LessThanOrEqual);

view.AutoSetDimensionsToSize(size: new CGSize(width: 32, height: 32));
```

Or ensure it is the same size as the dimension of another view:

```csharp
// Match Dimension with offset
view.AutoMatchDimension(dimension: ALDimension.Height, toDimension: ALDimension.Width, otherView: otherView);
view.AutoMatchDimension(dimension: ALDimension.Height, toDimension: ALDimension.Width, otherView: otherView, offset: 16f);
view.AutoMatchDimension(dimension: ALDimension.Height, toDimension: ALDimension.Width, otherView: otherView, offset: 16f, relation: NSLayoutRelation.GreaterThanOrEqual);

// Match Dimension with multiplier
view.AutoMatchDimensionWithMultiplier(dimension: ALDimension.Height, toDimension: ALDimension.Width, otherView: otherView, multiplier: 2f);
view.AutoMatchDimensionWithMultiplier(dimension: ALDimension.Height, toDimension: ALDimension.Width, otherView: otherView, multiplier: 2f, relation: NSLayoutRelation.GreaterThanOrEqual);
```


## Building PureLayout.Net from scratch

If you want to build PureLayout.Net from scratch or contribute to the binding library this section should give you enough information to build the project.

When cloning the project ensure that it is recursively checked out:

`git clone --recursive https://github.com/mallibone/PureLayout.Net.git`

To compile the Objective-C PureLayout library, run `make` from the project root folder.

This will compile the native Part of the library. If you now compile the Binding Project, the compiled native assembly will automatically be included.

To test any changes one can use the sample solution. Please note that many errors only occur at run time, so make sure to invoke any methods that you add or change to ensure they will work.


### Cleaning up

Once you have compiled the native PureLayout library you can delete all the generated assemblies by running `make clean` from  the root projects root directory.

## Thank you

A big thank you towards Tyler Fox (<a href="https://github.com/smileyborg" target="_blank">@smileyborg</a>) the original creator of <a href="https://github.com/PureLayout/PureLayout" target="_blank">PureLayout</a> and Mickey Reiss (<a href="https://github.com/mickeyreiss" target="_blank">@mickeyreiss</a>) current maintainer of the project for bringing this library to the iOS community.
