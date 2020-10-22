XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/PureLayout/PureLayout
PROJECT=$(PROJECT_ROOT)/PureLayout.xcodeproj
TARGET_IOS=PureLayout_iOS
TARGET_MAC=PureLayout_Mac
PROJECTNAME=PureLayout
BUILD_ROOT=$(ROOT)/PureLayout/PureLayout
POD_ROOT=PureLayout.Binding
OUTPUT=$(ROOT)/Build
BINDING_PROJECT_IOS=$(ROOT)/PureLayout.Binding/PureLayout.Binding
BINDING_PROJECT_MACOS=$(ROOT)/PureLayout.Binding/PureLayout.Binding.Mac
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios
FRAMEWORKS_MAC=$(ROOT)/Frameworks/mac

#lib$(TARGET_IOS).dll: lib$(TARGET_IOS)-i386.a lib$(TARGET_IOS)-armv7.a lib$(TARGET_IOS)-arm64.a lib$(TARGET_IOS).a
		#/Developer/MonoTouch/usr/bin/btouch-native -unsafe --outdir=. -out:$(TARGET_IOS).dll $(TARGET_IOS)_ApiDefinitions.cs $(TARGET_IOS)_StructsAndEnums.cs -x=linkwith.cs --link-with=lib$(TARGET_IOS).a,lib$(TARGET_IOS).a

all: ios mac

ios: $(FRAMEWORKS_IOS)/$(PROJECTNAME).framework $(BINDING_PROJECT_IOS)/Generated_ApiDefinitions.cs

$(FRAMEWORKS_IOS)/$(PROJECTNAME)-simulator.framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET_IOS) -sdk iphonesimulator -configuration Release clean build EXCLUDED_ARCHS="arm64"
	mkdir -p $(FRAMEWORKS_IOS)
	mv $(PROJECT_ROOT)/build/Release-iphonesimulator/$(PROJECTNAME).framework $@

$(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET_IOS) -sdk iphoneos -configuration Release clean build
	mkdir -p $(FRAMEWORKS_IOS)
	mv $(PROJECT_ROOT)/build/Release-iphoneos/$(PROJECTNAME).framework $@

$(BINDING_PROJECT_IOS)/Generated_ApiDefinitions.cs: $(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework
	sharpie bind -p Generated_ -sdk iphoneos14.0 -o $(BINDING_PROJECT_IOS) $(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework/Headers/PureLayout.h -scope $(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework/Headers

$(FRAMEWORKS_IOS)/$(PROJECTNAME).framework: $(FRAMEWORKS_IOS)/$(PROJECTNAME)-simulator.framework $(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework
	cp -R $(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework $@
	rm $@/$(PROJECTNAME)
	lipo -create -output $@/$(PROJECTNAME) $(FRAMEWORKS_IOS)/$(PROJECTNAME)-iphone.framework/$(PROJECTNAME) $(FRAMEWORKS_IOS)/$(PROJECTNAME)-simulator.framework/$(PROJECTNAME)

mac: $(FRAMEWORKS_MAC)/$(PROJECTNAME).framework $(BINDING_PROJECT_MACOS)/Generated_ApiDefinitions.cs

$(FRAMEWORKS_MAC)/$(PROJECTNAME).framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET_MAC) -sdk macosx -configuration Release clean build
	mkdir -p $(FRAMEWORKS_MAC)
	mv $(PROJECT_ROOT)/build/Release/$(PROJECTNAME).framework $@

$(BINDING_PROJECT_MACOS)/Generated_ApiDefinitions.cs: $(FRAMEWORKS_MAC)/$(PROJECTNAME).framework
	sharpie bind -p Generated_ -n PureLayout.Net -sdk macosx -xcodeproj-target PureLayout_Mac -o $(BINDING_PROJECT_MACOS) $(FRAMEWORKS_MAC)/$(PROJECTNAME).framework/Headers/PureLayout.h -scope $(FRAMEWORKS_MAC)/$(PROJECTNAME).framework/Headers

clean:
	-rm -rf $(PROJECT_ROOT)/build
	-rm -rf $(PROJECT_ROOT)/sharpie-build
	-rm -rf $(ROOT)/Frameworks
	-rm $(BINDING_PROJECT_IOS)/Generated_ApiDefinitions.cs
	-rm $(BINDING_PROJECT_IOS)/Generated_StructsAndEnums.cs
	-rm $(BINDING_PROJECT_MACOS)/Generated_ApiDefinitions.cs
	-rm $(BINDING_PROJECT_MACOS)/Generated_StructsAndEnums.cs
