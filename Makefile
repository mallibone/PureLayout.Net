XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/PureLayout/PureLayout
PROJECT=$(PROJECT_ROOT)/PureLayout.xcodeproj
TARGET=PureLayout
BUILD_ROOT=$(ROOT)/PureLayout/PureLayout
POD_ROOT=PureLayout.Binding
OUTPUT=$(ROOT)/Build

all: clean lib$(TARGET).dll

lib$(TARGET)-i386.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
			-mv $(BUILD_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $(OUTPUT)/$@

lib$(TARGET)-armv7.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
			-mv $(BUILD_ROOT)/build/Release-iphoneos/lib$(TARGET).a $(OUTPUT)/$@

lib$(TARGET)-arm64.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
		-mv $(BUILD_ROOT)/build/Release-iphoneos/lib$(TARGET).a $(OUTPUT)/$@

lib$(TARGET).a: $(OUTPUT)/lib$(TARGET)-i386.a $(OUTPUT)/lib$(TARGET)-armv7.a $(OUTPUT)/lib$(TARGET)-arm64.a
		xcrun -sdk iphoneos lipo -create -output $(OUTPUT)/$@ $^

lib$(TARGET).dll: lib$(TARGET)-i386.a lib$(TARGET)-armv7.a lib$(TARGET)-arm64.a lib$(TARGET).a
		/Developer/MonoTouch/usr/bin/btouch-native -unsafe --outdir=. -out:$(TARGET).dll $(TARGET)_ApiDefinitions.cs $(TARGET)_StructsAndEnums.cs -x=linkwith.cs --link-with=lib$(TARGET).a,lib$(TARGET).a

clean:
		-rm -f *.a *.dll

