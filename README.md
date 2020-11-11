# Android Build with CSharp Tests

This repository shows a few C# tests that use the page object model and AltUnityTester to test the Unity endless runner sample:
https://assetstore.unity.com/packages/essentials/tutorial-projects/endless-runner-sample-game-87901

### Running the tests on Android
The tests are meant to be run on an Adroid device. The app is provided in this repository, under the app/ folder.
To start the tests, depending of your OS run:
`./start_tests_android.sh`


This script will:

- start the app on your device
- run the tests
- stop the app after the test are done

