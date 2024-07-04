# Android Build with CSharp Tests

This repository shows a few C# tests that use the page object model and AltTester® Unity SDK to test the Unity Endless Runner sample:
https://assetstore.unity.com/packages/essentials/tutorial-projects/endless-runner-sample-game-87901

### Running the tests on Android

❗ Starting with version 2.0.0, the AltTester® Desktop must be running on your PC while the tests are running.
1. Download and install the AltTester® Desktop from [here](https://alttester.com/downloads/), then open it.
2. The tests are meant to be run on an Android device. Instrument the TrashCat application using the latest version of AltTester® Unity SDK - for additional information you can follow [this tutorial](https://alttester.com/walkthrough-tutorial-upgrading-trashcat-to-2-0-x/#Instrument%20TrashCat%20with%20AltTester%20Unity%20SDK%20v.2.0.x)
3. Create a folder `app` and include the instrumented app under the folder.
4. To start the tests, depending on your OS run:
    - `./run_tests_mac.sh on MacOS/Linux`
    - `./run_tests_windows.sh on Windows`

This script will:

- start the app on your device
- run the tests
- stop the app after the tests are done

