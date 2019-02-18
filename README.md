
# react-native-rxdnssd
## Introduction
This is a react-native wrapper for android https://github.com/andriydruk/RxDNSSD library. This has to be used only in android by making a check specifically so that this is used only on an android device.

## Getting started

`$ npm install react-native-rxdnssd --save`

### Mostly automatic installation

`$ react-native link react-native-rxdnssd`

### Manual installation

#### Android

1. Open up `android/app/src/main/java/[...]/MainApplication.java`
  - Add `import com.reactlibrary.RxdnssdPackage;` to the imports at the top of the file
  - Add `new RxdnssdPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-rxdnssd'
  	project(':react-native-rxdnssd').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-rxdnssd/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-rxdnssd')
  	```

#### iOS
iOS is not supported as rxdnssd is a android only project.

#### Windows
Windows is not supported as rxdnssd is an android only library

## Usage
```javascript
import RNRxdnssd from 'react-native-rxdnssd';

// TODO: What to do with the module?
RNRxdnssd;
```
