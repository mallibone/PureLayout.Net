using System;
using AppKit;
using CoreGraphics;
using Foundation;
using PureLayout;

namespace PureLayout.Net
{
	// typedef void (^ALConstraintsBlock)();
	delegate void ALConstraintsBlock ();

	// @interface PureLayout (NSView)
	[Category]
	[BaseType (typeof(NSView))]
	interface NSView_PureLayout
	{
		// +(instancetype _Nonnull)newAutoLayoutView;
		[Static]
		[Export ("newAutoLayoutView")]
		NSView NewAutoLayoutView ();

		// -(instancetype _Nonnull)configureForAutoLayout;
		[Export ("configureForAutoLayout")]
		NSView ConfigureForAutoLayout ();

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoCenterInSuperview;
		[Export ("autoCenterInSuperview")]
		//[Verify (MethodToProperty)]
		NSLayoutConstraint[] AutoCenterInSuperview();

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxisToSuperviewAxis:(ALAxis)axis;
		[Export ("autoAlignAxisToSuperviewAxis:")]
		NSLayoutConstraint AutoAlignAxisToSuperviewAxis (ALAxis axis);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewEdge:(ALEdge)edge;
		[Export ("autoPinEdgeToSuperviewEdge:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge (ALEdge edge);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewEdge:(ALEdge)edge withInset:(CGFloat)inset;
		[Export ("autoPinEdgeToSuperviewEdge:withInset:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge (ALEdge edge, nfloat inset);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdgeToSuperviewEdge:(ALEdge)edge withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export ("autoPinEdgeToSuperviewEdge:withInset:relation:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge (ALEdge edge, nfloat inset, NSLayoutRelation relation);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewEdges;
		[Export ("autoPinEdgesToSuperviewEdges")]
		//[Verify (MethodToProperty)]
		NSLayoutConstraint[] AutoPinEdgesToSuperviewEdges();

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewEdgesWithInsets:(NSEdgeInsets)insets;
		[Export ("autoPinEdgesToSuperviewEdgesWithInsets:")]
		NSLayoutConstraint[] AutoPinEdgesToSuperviewEdgesWithInsets (NSEdgeInsets insets);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoPinEdgesToSuperviewEdgesWithInsets:(NSEdgeInsets)insets excludingEdge:(ALEdge)edge;
		[Export ("autoPinEdgesToSuperviewEdgesWithInsets:excludingEdge:")]
		NSLayoutConstraint[] AutoPinEdgesToSuperviewEdgesWithInsets (NSEdgeInsets insets, ALEdge edge);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(NSView * _Nonnull)otherView;
		[Export ("autoPinEdge:toEdge:ofView:")]
		NSLayoutConstraint AutoPinEdge (ALEdge edge, ALEdge toEdge, NSView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export ("autoPinEdge:toEdge:ofView:withOffset:")]
		NSLayoutConstraint AutoPinEdge (ALEdge edge, ALEdge toEdge, NSView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export ("autoPinEdge:toEdge:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoPinEdge (ALEdge edge, ALEdge toEdge, NSView otherView, nfloat offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(NSView * _Nonnull)otherView;
		[Export ("autoAlignAxis:toSameAxisOfView:")]
		NSLayoutConstraint AutoAlignAxis (ALAxis axis, NSView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export ("autoAlignAxis:toSameAxisOfView:withOffset:")]
		NSLayoutConstraint AutoAlignAxisWithOffset (ALAxis axis, NSView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(NSView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier;
		[Export ("autoAlignAxis:toSameAxisOfView:withMultiplier:")]
		NSLayoutConstraint AutoAlignAxisWithMultiplier(ALAxis axis, NSView otherView, nfloat multiplier);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(NSView * _Nonnull)otherView;
		[Export ("autoMatchDimension:toDimension:ofView:")]
		NSLayoutConstraint AutoMatchDimension (ALDimension dimension, ALDimension toDimension, NSView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export ("autoMatchDimension:toDimension:ofView:withOffset:")]
		NSLayoutConstraint AutoMatchDimensionWithOffset (ALDimension dimension, ALDimension toDimension, NSView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export ("autoMatchDimension:toDimension:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoMatchDimensionWithOffset (ALDimension dimension, ALDimension toDimension, NSView otherView, nfloat offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(NSView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier;
		[Export ("autoMatchDimension:toDimension:ofView:withMultiplier:")]
		NSLayoutConstraint AutoMatchDimensionWithMultiplier (ALDimension dimension, ALDimension toDimension, NSView otherView, nfloat multiplier);

		// -(NSLayoutConstraint * _Nonnull)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(NSView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier relation:(NSLayoutRelation)relation;
		[Export ("autoMatchDimension:toDimension:ofView:withMultiplier:relation:")]
		NSLayoutConstraint AutoMatchDimensionWithMultiplier (ALDimension dimension, ALDimension toDimension, NSView otherView, nfloat multiplier, NSLayoutRelation relation);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoSetDimensionsToSize:(CGSize)size;
		[Export ("autoSetDimensionsToSize:")]
		NSLayoutConstraint[] AutoSetDimensionsToSize (CGSize size);

		// -(NSLayoutConstraint * _Nonnull)autoSetDimension:(ALDimension)dimension toSize:(CGFloat)size;
		[Export ("autoSetDimension:toSize:")]
		NSLayoutConstraint AutoSetDimension (ALDimension dimension, nfloat size);

		// -(NSLayoutConstraint * _Nonnull)autoSetDimension:(ALDimension)dimension toSize:(CGFloat)size relation:(NSLayoutRelation)relation;
		[Export ("autoSetDimension:toSize:relation:")]
		NSLayoutConstraint AutoSetDimension (ALDimension dimension, nfloat size, NSLayoutRelation relation);

		// -(void)autoSetContentCompressionResistancePriorityForAxis:(ALAxis)axis;
		[Export ("autoSetContentCompressionResistancePriorityForAxis:")]
		void AutoSetContentCompressionResistancePriorityForAxis (ALAxis axis);

		// -(void)autoSetContentHuggingPriorityForAxis:(ALAxis)axis;
		[Export ("autoSetContentHuggingPriorityForAxis:")]
		void AutoSetContentHuggingPriorityForAxis (ALAxis axis);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(NSView * _Nonnull)otherView;
		[Export ("autoConstrainAttribute:toAttribute:ofView:")]
		NSLayoutConstraint AutoConstrainAttribute (ALAttribute attribute, ALAttribute toAttribute, NSView otherView);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withOffset:")]
		NSLayoutConstraint AutoConstrainAttributeWithOffset (ALAttribute attribute, ALAttribute toAttribute, NSView otherView, nfloat offset);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(NSView * _Nonnull)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoConstrainAttributeWithOffset (ALAttribute attribute, ALAttribute toAttribute, NSView otherView, nfloat offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(NSView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withMultiplier:")]
		NSLayoutConstraint AutoConstrainAttributeWithMultiplier (ALAttribute attribute, ALAttribute toAttribute, NSView otherView, nfloat multiplier);

		// -(NSLayoutConstraint * _Nonnull)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(NSView * _Nonnull)otherView withMultiplier:(CGFloat)multiplier relation:(NSLayoutRelation)relation;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withMultiplier:relation:")]
		NSLayoutConstraint AutoConstrainAttributeWithMultiplier (ALAttribute attribute, ALAttribute toAttribute, NSView otherView, nfloat multiplier, NSLayoutRelation relation);
	}

	// @interface PureLayout (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_PureLayout
	{
		// -(void)autoInstallConstraints;
		[Export ("autoInstallConstraints")]
		void AutoInstallConstraints ();

		// -(void)autoRemoveConstraints;
		[Export ("autoRemoveConstraints")]
		void AutoRemoveConstraints ();

		// -(instancetype _Nonnull)autoIdentifyConstraints:(NSString * _Nonnull)identifier;
		[Export ("autoIdentifyConstraints:")]
		NSArray AutoIdentifyConstraints (string identifier);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoAlignViewsToEdge:(ALEdge)edge;
		[Export ("autoAlignViewsToEdge:")]
		NSLayoutConstraint[] AutoAlignViewsToEdge (ALEdge edge);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoAlignViewsToAxis:(ALAxis)axis;
		[Export ("autoAlignViewsToAxis:")]
		NSLayoutConstraint[] AutoAlignViewsToAxis (ALAxis axis);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoMatchViewsDimension:(ALDimension)dimension;
		[Export ("autoMatchViewsDimension:")]
		NSLayoutConstraint[] AutoMatchViewsDimension (ALDimension dimension);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoSetViewsDimension:(ALDimension)dimension toSize:(CGFloat)size;
		[Export ("autoSetViewsDimension:toSize:")]
		NSLayoutConstraint[] AutoSetViewsDimension (ALDimension dimension, nfloat size);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoSetViewsDimensionsToSize:(CGSize)size;
		[Export ("autoSetViewsDimensionsToSize:")]
		NSLayoutConstraint[] AutoSetViewsDimensionsToSize (CGSize size);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxis (ALAxis axis, ALAttribute alignment, nfloat spacing);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing insetSpacing:(BOOL)shouldSpaceInsets;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:insetSpacing:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxis (ALAxis axis, ALAttribute alignment, nfloat spacing, bool shouldSpaceInsets);

		// -(NSArray<NSLayoutConstraint *> * _Nonnull)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing insetSpacing:(BOOL)shouldSpaceInsets matchedSizes:(BOOL)shouldMatchSizes;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:insetSpacing:matchedSizes:")]
		NSLayoutConstraint[] AutoDistributeViewsAlongAxis (ALAxis axis, ALAttribute alignment, nfloat spacing, bool shouldSpaceInsets, bool shouldMatchSizes);
	}

	// @interface PureLayout (NSLayoutConstraint)
	[Category]
	[BaseType (typeof(NSLayoutConstraint))]
	interface NSLayoutConstraint_PureLayout
	{
		// +(NSArray<NSLayoutConstraint *> * _Nonnull)autoCreateAndInstallConstraints:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export ("autoCreateAndInstallConstraints:")]
		NSLayoutConstraint[] AutoCreateAndInstallConstraints (ALConstraintsBlock block);

		// +(NSArray<NSLayoutConstraint *> * _Nonnull)autoCreateConstraintsWithoutInstalling:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export ("autoCreateConstraintsWithoutInstalling:")]
		NSLayoutConstraint[] AutoCreateConstraintsWithoutInstalling (ALConstraintsBlock block);

		// +(void)autoSetPriority:(NSLayoutPriority)priority forConstraints:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export ("autoSetPriority:forConstraints:")]
		void AutoSetPriority (float priority, ALConstraintsBlock block);

		// +(void)autoSetIdentifier:(NSString * _Nonnull)identifier forConstraints:(ALConstraintsBlock _Nonnull)block;
		[Static]
		[Export ("autoSetIdentifier:forConstraints:")]
		void AutoSetIdentifier (string identifier, ALConstraintsBlock block);

		// -(instancetype _Nonnull)autoIdentify:(NSString * _Nonnull)identifier;
		[Export ("autoIdentify:")]
		NSLayoutConstraint AutoIdentify (string identifier);

		// -(void)autoInstall;
		[Export ("autoInstall")]
		void AutoInstall ();

		// -(void)autoRemove;
		[Export ("autoRemove")]
		void AutoRemove ();
	}
}
