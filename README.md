# Android Build with CSharp Tests

This repository shows a few C# tests that use the page object model and AltTester to test the Unity endless runner sample:
https://assetstore.unity.com/packages/essentials/tutorial-projects/endless-runner-sample-game-87901

### Running the tests on Android
The tests are meant to be run on an Adroid device. Create a folder app under project

The app is provided at https://altom.com/app/uploads/AltTester/TrashCat/TrashCatAndroid.zip and needs to be included unzipped under the app/ folder.

To start the tests, depending of your OS run:
 - ./run_tests_mac.sh on MacOS/Linux
 - ./run_tests_windows.sh on Windows

This script will:

- start the app on your device
- run the tests
- stop the app after the test are done

