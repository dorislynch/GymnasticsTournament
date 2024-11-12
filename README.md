
# react-native-gymnastics-tournament

## Getting started

`$ npm install react-native-gymnastics-tournament --save`

### Mostly automatic installation

`$ react-native link react-native-gymnastics-tournament`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-gymnastics-tournament` and add `RNGymnasticsTournament.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNGymnasticsTournament.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNGymnasticsTournamentPackage;` to the imports at the top of the file
  - Add `new RNGymnasticsTournamentPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-gymnastics-tournament'
  	project(':react-native-gymnastics-tournament').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-gymnastics-tournament/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-gymnastics-tournament')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNGymnasticsTournament.sln` in `node_modules/react-native-gymnastics-tournament/windows/RNGymnasticsTournament.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Gymnastics.Tournament.RNGymnasticsTournament;` to the usings at the top of the file
  - Add `new RNGymnasticsTournamentPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNGymnasticsTournament from 'react-native-gymnastics-tournament';

// TODO: What to do with the module?
RNGymnasticsTournament;
```
  