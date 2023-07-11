# Android Build with CSharp Tests

This repository shows a few C# tests that use the page object model and AltTester Unity SDK to test the Unity endless runner sample:
https://assetstore.unity.com/packages/essentials/tutorial-projects/endless-runner-sample-game-87901

### Running the tests on Android

1. Install the [AltTesterDesktop](https://alttester.com/alttester/#pricing), then open it (you need to accept the Terms and Conditions if the AltTester is opened for the first time).
2. The tests are meant to be run on an Adroid device. Create a folder `app` under project. The app is provided at https://alttester.com/app/uploads/AltTester/TrashCat/TrashCatAndroid2_0_1.zip and needs to be included unzipped under the `app/` folder.
3. To start the tests, depending on your OS run:
    - `./run_tests_mac.sh on MacOS/Linux`
    - `./run_tests_windows.sh on Windows`

This script will:

- start the app on your device
- run the tests
- stop the app after the test are done

