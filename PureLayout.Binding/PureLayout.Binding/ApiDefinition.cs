using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace PureLayout.Net
{
	// typedef void (^ALConstraintsBlock)();
	delegate void ALConstraintsBlock();

	// @interface PureLayout (UIView)
	[Category]
	[BaseType(typeof(UIView))]
	interface UIViewPureLayout
	{
		// +(instancetype _Nonnull)newAutoLayoutView;
		[Static]
		[Export("newAutoLayoutView")]
		UIView NewAutoLayoutView();

		// -(instancetype _Nonnull)configureForAutoLayout;
		[Export("configureForAutoLayout")]
		UIView ConfigureForAutoLayout();

        // -(NSArray<NSLayoutConstraint *> * _Nonnull)autoCenterInSuperview;
        [Export("autoCenterInSuperview")]
        //[Verify(MethodToProperty)]
        NSLayoutConstraint[] AutoCenterInSuperview();

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxisToSuperviewAxis:(ALAxis)axis;
		[Export("autoAlignAxisToSuperviewAxis:")]
		NSLayoutConstraint AutoAlignAxisToSuperviewAxis(ALAxis axis);

        // -(NSArray<NSLayoutConstraint *> * _Nonnull)autoCenterInSuperviewMargins;
        [Export("autoCenterInSuperviewMargins")]
        //[Verify(MethodToProperty)]
        NSLayoutConstraint[] AutoCenterInSuperviewMargins();

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxisToSuperviewMarginAxis:(ALAxis)axis;
		[Export("autoAlignAxisToSuperviewMarginAxis:")]
		NSLayoutConstraint AutoAlignAxisToSuperviewMarginAxis(ALAxis axis);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewEdge:(ALEdge)edge;
		[Export("autoPinEdgeToSuperviewEdge:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge(ALEdge edge);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewEdge:(ALEdge)edge withInset:(CGFloat)inset;
		[Export("autoPinEdgeToSuperviewEdge:withInset:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge(ALEdge edge, nfloat inset);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewEdge:(ALEdge)edge withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export("autoPinEdgeToSuperviewEdge:withInset:relation:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge(ALEdge edge, nfloat inset, NSLayoutRelation relation);

        // -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewEdges;
        [Export("autoPinEdgesToSuperviewEdges")]
        //[Verify(MethodToProperty)]
        NSLayoutConstraint[] AutoPinEdgesToSuperviewEdges();

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewEdgesWithInsets:(UIEdgeInsets)insets;
		[Export("autoPinEdgesToSuperviewEdgesWithInsets:")]
		NSLayoutConstraint[] AutoPinEdgesToSuperviewEdgesWithInsets(UIEdgeInsets insets);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewEdgesWithInsets:(UIEdgeInsets)insets excludingEdge:(ALEdge)edge;
		[Export("autoPinEdgesToSuperviewEdgesWithInsets:excludingEdge:")]
		NSLayoutConstraint[] AutoPinEdgesToSuperviewEdgesWithInsets(UIEdgeInsets insets, ALEdge edge);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewMargin:(ALEdge)edge;
		[Export("autoPinEdgeToSuperviewMargin:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewMargin(ALEdge edge);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewMargin:(ALEdge)edge relation:(NSLayoutRelation)relation;
		[Export("autoPinEdgeToSuperviewMargin:relation:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewMargin(ALEdge edge, NSLayoutRelation relation);

        // -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewMargins;
        [Export("autoPinEdgesToSuperviewMargins")]
        //[Verify(MethodToProperty)]
        NSLayoutConstraint[] AutoPinEdgesToSuperviewMargins();

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewMarginsExcludingEdge:(ALEdge)edge;
		[Export("autoPinEdgesToSuperviewMarginsExcludingEdge:")]
		NSLayoutConstraint[] AutoPinEdgesToSuperviewMarginsExcludingEdge(ALEdge edge);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(UIView * _Nonnull)otherView;
		[Export("autoPinEdge:toEdge:ofView:")]
		NSLayoutConstraint AutoPinEdge(ALEdge edge, ALEdge toEdge, UIView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export("autoPinEdge:toEdge:ofView:withOffset:")]
		NSLayoutConstraint AutoPinEdge(ALEdge edge, ALEdge toEdge, UIView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export("autoPinEdge:toEdge:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoPinEdge(ALEdge edge, ALEdge toEdge, UIView otherView, nfloat offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(UIView * _Nonnull)otherView;
		[Export("autoAlignAxis:toSameAxisOfView:")]
		NSLayoutConstraint AutoAlignAxis(ALAxis axis, UIView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export("autoAlignAxis:toSameAxisOfView:withOffset:")]
		NSLayoutConstraint AutoAlignAxis(ALAxis axis, UIView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(UIView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier;
		[Export("autoAlignAxis:toSameAxisOfView:withMultiplier:")]
		NSLayoutConstraint AutoAlignAxisWithMultiplier(ALAxis axis, UIView otherView, nfloat multiplier);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView * _Nonnull)otherView;
		[Export("autoMatchDimension:toDimension:ofView:")]
		NSLayoutConstraint AutoMatchDimension(ALDimension dimension, ALDimension toDimension, UIView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export("autoMatchDimension:toDimension:ofView:withOffset:")]
		NSLayoutConstraint AutoMatchDimension(ALDimension dimension, ALDimension toDimension, UIView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export("autoMatchDimension:toDimension:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoMatchDimension(ALDimension dimension, ALDimension toDimension, UIView otherView, nfloat offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier;
		[Export("autoMatchDimension:toDimension:ofView:withMultiplier:")]
		NSLayoutConstraint AutoMatchDimensionWithMultiplier(ALDimension dimension, ALDimension toDimension, UIView otherView, nfloat multiplier);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier relation:(NSLayoutRelation)relation;
		[Export("autoMatchDimension:toDimension:ofView:withMultiplier:relation:")]
		NSLayoutConstraint AutoMatchDimensionWithMultiplier(ALDimension dimension, ALDimension toDimension, UIView otherView, nfloat multiplier, NSLayoutRelation relation);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoSetDimensionsToSize:(CGSize)size;
		[Export("autoSetDimensionsToSize:")]
		NSLayoutConstraint[] AutoSetDimensionsToSize(CGSize size);

		// -(NSLayoutConstraint * _Nonnull)autoSetDimension:(ALDimension)dimension toSize:(CGFloat)size;
		[Export("autoSetDimension:toSize:")]
		NSLayoutConstraint AutoSetDimension(ALDimension dimension, nfloat size);

		// -(NSLayoutConstraint * _Nonnull)autoSetDimension:(ALDimension)dimension toSize:(CGFloat)size relation:(NSLayoutRelation)relation;
		[Export("autoSetDimension:toSize:relation:")]
		NSLayoutConstraint AutoSetDimension(ALDimension dimension, nfloat size, NSLayoutRelation relation);

		// -(void)autoSetContentCompressionResistancePriorityForAxis:(ALAxis)axis;
		[Export("autoSetContentCompressionResistancePriorityForAxis:")]
		void AutoSetContentCompressionResistancePriorityForAxis(ALAxis axis);

		// -(void)autoSetContentHuggingPriorityForAxis:(ALAxis)axis;
		[Export("autoSetContentHuggingPriorityForAxis:")]
		void AutoSetContentHuggingPriorityForAxis(ALAxis axis);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView * _Nonnull)otherView;
		[Export("autoConstrainAttribute:toAttribute:ofView:")]
		NSLayoutConstraint AutoConstrainAttribute(ALAttribute attribute, ALAttribute toAttribute, UIView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export("autoConstrainAttribute:toAttribute:ofView:withOffset:")]
		NSLayoutConstraint AutoConstrainAttribute(ALAttribute attribute, ALAttribute toAttribute, UIView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView * _Nonnull)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export("autoConstrainAttribute:toAttribute:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoConstrainAttribute(ALAttribute attribute, ALAttribute toAttribute, UIView otherView, nfloat offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier;
		[Export("autoConstrainAttribute:toAttribute:ofView:withMultiplier:")]
		NSLayoutConstraint AutoConstrainAttributeWithMultiplier(ALAttribute attribute, ALAttribute toAttribute, UIView otherView, nfloat multiplier);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier relation:(NSLayoutRelation)relation;
		[Export("autoConstrainAttribute:toAttribute:ofView:withMultiplier:relation:")]
		NSLayoutConstraint AutoConstrainAttributeWithMultiplier(ALAttribute attribute, ALAttribute toAttribute, UIView otherView, nfloat multiplier, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoPinToTopLayoutGuideOfViewController:(UIViewController * _Nonnull)viewController withInset:(CGFloat)inset;
		[Export("autoPinToTopLayoutGuideOfViewController:withInset:")]
		NSLayoutConstraint AutoPinToTopLayoutGuideOfViewController(UIViewController viewController, nfloat inset);

		// -(NSLayoutConstraint * _Nonnull)autoPinToTopLayoutGuideOfViewController:(UIViewController * _Nonnull)viewController withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export("autoPinToTopLayoutGuideOfViewController:withInset:relation:")]
		NSLayoutConstraint AutoPinToTopLayoutGuideOfViewController(UIViewController viewController, nfloat inset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoPinToBottomLayoutGuideOfViewController:(UIViewController * _Nonnull)viewController withInset:(CGFloat)inset;
		[Export("autoPinToBottomLayoutGuideOfViewController:withInset:")]
		NSLayoutConstraint AutoPinToBottomLayoutGuideOfViewController(UIViewController viewController, nfloat inset);

		// -(NSLayoutConstraint * _Nonnull)autoPinToBottomLayoutGuideOfViewController:(UIViewController * _Nonnull)viewController withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export("autoPinToBottomLayoutGuideOfViewController:withInset:relation:")]
		NSLayoutConstraint AutoPinToBottomLayoutGuideOfViewController(UIViewController viewController, nfloat inset, NSLayoutRelation relation);
	}

	// @interface PureLayout (NSArray)
	[Category]
	[BaseType(typeof(NSArray))]
	interface NSArrayPureLayout
	{
		// -(void)autoInstallConstraints;
		[Export("autoInstallConstraints")]
		void AutoInstallConstraints();

		// -(void)autoRemoveConstraints;
		[Export("autoRemoveConstraints")]
		void AutoRemoveConstraints();

		// -(instancetype _Nonnull)autoIdentifyConstraints:(NSString * _Nonnull)identifier;
		[Export("autoIdentifyConstraints:")]
		NSArray AutoIdentifyConstraints(string identifier);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoAlignViewsToEdge:(ALEdge)edge;
		[Export("autoAlignViewsToEdge:")]
		NSLayoutConstraint[] AutoAlignViewsToEdge(ALEdge edge);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoAlignViewsToAxis:(ALAxis)axis;
		[Export("autoAlignViewsToAxis:")]
		NSLayoutConstraint[] AutoAlignViewsToAxis(ALAxis axis);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoMatchViewsDimension:(ALDimension)dimension;
		[Export("autoMatchViewsDimension:")]
		NSLayoutConstraint[] AutoMatchViewsDimension(ALDimension dimension);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoSetViewsDimension:(ALDimension)dimension toSize:(CGFloat)size;
		[Export("autoSetViewsDimension:toSize:")]
		NSLayoutConstraint[] AutoSetViewsDimension(ALDimension dimension, nfloat size);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoSetViewsDimensionsToSize:(CGSize)size;
		[Export("autoSetViewsDimensionsToSize:")]
		NSLayoutConstraint[] AutoSetViewsDimensionsToSize(CGSize size);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing;
		[Export("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxis(ALAxis axis, ALAttribute alignment, nfloat spacing);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing insetSpacing:(BOOL)shouldSpaceInsets;
		[Export("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:insetSpacing:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxis(ALAxis axis, ALAttribute alignment, nfloat spacing, bool shouldSpaceInsets);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing insetSpacing:(BOOL)shouldSpaceInsets matchedSizes:(BOOL)shouldMatchSizes;
		[Export("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:insetSpacing:matchedSizes:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxis(ALAxis axis, ALAttribute alignment, nfloat spacing, bool shouldSpaceInsets, bool shouldMatchSizes);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSize:(CGFloat)size;
		[Export("autoDistributeViewsAlongAxis:alignedTo:withFixedSize:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxisWithFixedSize(ALAxis axis, ALAttribute alignment, nfloat size);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSize:(CGFloat)size insetSpacing:(BOOL)shouldSpaceInsets;
		[Export("autoDistributeViewsAlongAxis:alignedTo:withFixedSize:insetSpacing:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxisWithFixedSize(ALAxis axis, ALAttribute alignment, nfloat size, bool shouldSpaceInsets);
	}

	// @interface PureLayout (NSLayoutConstraint)
	[Category]
	[BaseType(typeof(NSLayoutConstraint))]
	interface NSLayoutConstraintPureLayout
	{
		// +(NSArray<NSLayoutConstraint *> * _Nonnull)autoCreateAndInstallConstraints:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export("autoCreateAndInstallConstraints:")]
		NSLayoutConstraint[] AutoCreateAndInstallConstraints(ALConstraintsBlock block);

		// +(NSArray<NSLayoutConstraint *> * _Nonnull)autoCreateConstraintsWithoutInstalling:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export("autoCreateConstraintsWithoutInstalling:")]
		NSLayoutConstraint[] AutoCreateConstraintsWithoutInstalling(ALConstraintsBlock block);

		// +(void)autoSetPriority:(UILayoutPriority)priority forConstraints:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export("autoSetPriority:forConstraints:")]
		void AutoSetPriority(float priority, ALConstraintsBlock block);

		// +(void)autoSetIdentifier:(NSString * _Nonnull)identifier forConstraints:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export("autoSetIdentifier:forConstraints:")]
		void AutoSetIdentifier(string identifier, ALConstraintsBlock block);

		// -(instancetype _Nonnull)autoIdentify:(NSString * _Nonnull)identifier;
		[Export("autoIdentify:")]
		NSLayoutConstraint AutoIdentify(string identifier);

		// -(void)autoInstall;
		[Export("autoInstall")]
		void AutoInstall();

		// -(void)autoRemove;
		[Export("autoRemove")]
		void AutoRemove();
	}
}
