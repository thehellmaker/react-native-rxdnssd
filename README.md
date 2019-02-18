
# react-native-rxdnssd

## Getting started

`$ npm install react-native-rxdnssd --save`

### Mostly automatic installation

`$ react-native link react-native-rxdnssd`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-rxdnssd` and add `Rxdnssd.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRxdnssd.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
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

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `Rxdnssd.sln` in `node_modules/react-native-rxdnssd/windows/Rxdnssd.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Rxdnssd.Rxdnssd;` to the usings at the top of the file
  - Add `new RxdnssdPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import Rxdnssd from 'react-native-rxdnssd';

// TODO: What to do with the module?
Rxdnssd;
```
  