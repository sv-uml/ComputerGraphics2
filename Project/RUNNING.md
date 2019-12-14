# Overview
There are two projects in the "App" folder:
1. Unity Hololens project
2. Visual Studio project that is generated once the Unity project is built

# Deployment
If you would like to deploy/execute the application to a Hololens device directly, go to the Build folder and perform the following steps:

1. Connect the Hololens to the computer and ensure that "Windows Hololens" is listed under "Universal Serial Bus devices" in Windows Device Manager
2. Open ScrumGram.sln
3. Once Visual Studio loads the project, make the following changes;
    - Running type: Release
    - Architecture: x86
    - Target: Device
4. Hit the Play button, which should install the app on the Hololens and automatically start it


# Developing
The general step to develop an app is to design the program in Unity and build it for Visual Studio, where it is then deployed to the device.

1. Go to the App/Assets/Scenes folder and open Home.unity
2. Ensure that Unity has Windows SDK and other dependencies set up
3. Once an application is ready to be deployed, go to File > Build Settings
4. Click on Add Open Scenes
5. Click on Build to generate Visual Studio sources
    - If an output folder is not set up, then Unity will ask to select a folder where the generated Visual Studio code should be saved
6. Assuming "Build" is the output folder, go to App/Build and open ScrumGram.sln. Follow the instructions under the `Deployment` section to build and deploy the application to the Hololens.