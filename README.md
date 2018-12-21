# Night at the Museum
Project created by Erika Gangware.

This project is a summary of how the Interior Design industry can benefit from Virtual Reality, and the many different use cases for designing environments in VR.


To read the write up for this project, go to the following link: 
http://www.erikagangware.com/interiordesign_vrapp/
 

Project title for "Night at the Museum" is also interchangeable with "Rightsizechallenge" (the title of the Unity Project) and "Interior Design Tour" (the title used on write up web page)


project for the Udacity [VR Developer Nanodegree](http://udacity.com/vr) program.


- Course: VR Design
- Project: Night at the Museum


### Versions Used
- [Unity LTS Release 2017.4.4](https://unity3d.com/unity/qa/lts-releases?version=2017.4)
- [GVR SDK for Unity v1.100.1](https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.100.1)


### Directory Structure
- The Unity project is the child directory of the repository.
- The Unity project is 'cleaned' and includes the `Assets` folder, the `ProjectSettings` folder, and the `UnityPackageManager` folder.


### GVR SDK for Unity
- `GoogleVR` > `Demos` is not included.
- `GoogleVR` > `GVRVideoPlayer.unitypackage` is included.
- The `Max Reticle Distance` value for the `GvrReticlePointer` used in the scene is set to `20` instead of the default `10`.
- Scripts applicable to the course have been updated to reflect Unity's API change from `UnityEngine.VR` to `UnityEngine.XR`.

>**Note:** If for any reason you remove and re-import GVR SDK for Unity v1.100.1, make sure you accept any API update pop-up prompts triggered by Unity. Alternatively, you can manually run the API updater (Unity menu `Assets` > `Run API Updater...`) after the import has completed.
