XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/PureLayout/PureLayout
PROJECT=$(PROJECT_ROOT)/PureLayout.xcodeproj
TARGET=PureLayout_iOS
PROJECTNAME=PureLayout
BUILD_ROOT=$(ROOT)/PureLayout/PureLayout
POD_ROOT=PureLayout.Binding
OUTPUT=$(ROOT)/Build
BINDING_PROJECT=$(ROOT)/PureLayout.Binding/PureLayout.Binding

#lib$(TARGET).dll: lib$(TARGET)-i386.a lib$(TARGET)-armv7.a lib$(TARGET)-arm64.a lib$(TARGET).a
		#/Developer/MonoTouch/usr/bin/btouch-native -unsafe --outdir=. -out:$(TARGET).dll $(TARGET)_ApiDefinitions.cs $(TARGET)_StructsAndEnums.cs -x=linkwith.cs --link-with=lib$(TARGET).a,lib$(TARGET).a

all: $(PROJECTNAME).framework

$(PROJECTNAME)-simulator.framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	mv $(PROJECT_ROOT)/build/Release-iphonesimulator/$(PROJECTNAME).framework $(PROJECTNAME)-simulator.framework

$(PROJECTNAME)-iphone.framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build
	mv $(PROJECT_ROOT)/build/Release-iphoneos/$(PROJECTNAME).framework $(PROJECTNAME)-iphone.framework

$(BINDING_PROJECT)/Generated_ApiDefinitions.cs:
	 sharpie bind -p Generated_ -sdk iphoneos13.7 -o $(BINDING_PROJECT) ./$(PROJECTNAME)-iphone.framework/Headers/PureLayout.h -scope ./$(PROJECTNAME)-iphone.framework/Headers

$(PROJECTNAME).framework: $(PROJECTNAME)-simulator.framework $(PROJECTNAME)-iphone.framework $(BINDING_PROJECT)/Generated_ApiDefinitions.cs
	cp -R $(PROJECTNAME)-iphone.framework ./$(PROJECTNAME).framework
	rm ./$(PROJECTNAME).framework/$(PROJECTNAME)
	lipo -create -output $(PROJECTNAME).framework/$(PROJECTNAME) $(PROJECTNAME)-iphone.framework/$(PROJECTNAME) $(PROJECTNAME)-simulator.framework/$(PROJECTNAME)

clean:
	rm -rf $(PROJECT_ROOT)/build
	rm -rf $(PROJECT_ROOT)/sharpie-build
	rm -rf *.framework
	rm $(BINDING_PROJECT)/Generated_ApiDefinitions.cs
	rm $(BINDING_PROJECT)/Generated_StructsAndEnums.cs
