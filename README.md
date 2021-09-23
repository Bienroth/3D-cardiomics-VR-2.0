# VR-Cardiomics

## Overview

VR-Cardiomics provides a framework to map multi-dimensional data (such as intensity and location of gene expression) on to 3D models in a heatmap-like manner. In our use case the intensity is the level of gene expression of those expressed in the adult heart, and the location is this expression level in 18 discrete pieces of the heart as measured by RNA-seq.

Code for the manuscript: Denis Bienroth<sup>\*</sup>, Hieu T. Nim, Dimitar Garkov, Karsten Klein, Sabrina Jaeger-Honz, Mirana Ramialison<sup>#</sup> and Falk Schreiber<sup>#</sup>. "Spatially-Resolved Transcriptomics in ImmersiveEnvironments" (<sup>\*</sup>: first author; <sup>#</sup>: corresponding authors)

VR-Cardiomics is designed to map user generated data onto a user specific 3D model. However, the data and the model must meet certain requirements. Please refer to the chapter #Upload Custom Data for more information on how to use VR-cardiomics as a framework for own data and models on your local machine.

This application supports VR devices as listed [below](#dependencies), our [web application](https://github.com/Ramialison-Lab/3DCardiomics) and [zSpace](https://github.com/Ramialison-Lab/3DCardiomicsZSpace) are available as well.

## Navigate
- [Dependencies](#dependencies)
- [How to run VR-Cardiomics](#runVR)
- [VR-Cardiomics Features](#features)
- [Upload custom data](#custom)
- [Troubleshooting](#trouble)

## <a name="dependencies">Dependencies </a>

-   Unity (2019.4.19f1)

Currently fully supported VR devices include: 
-  	Oculus Quest / Quest 2 (Link mode)
-	Oculus Rift / Rift S 
Other devices may not be fully supported.

## <a name="runVR">How to run VR-Cardiomics </a>

The simplest way to run VR-Cardiomics is by using Unity [2019.4.19f1](https://unity3d.com/de/unity/whats-new/2019.4.19). Copy VR-Cardiomics from github to your local machine ([how to copy from github](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)) and open it in Unity (Information on how to open an exisiting project in Unity can be found [here](https://docs.unity3d.com/2019.1/Documentation/Manual/GettingStartedOpeningProjects.html)).

*It is recommended to ignore update notifications from Unity in order to ensure that the application is processed as expected.*

## <a name="features">VR-Cardiomics Features</a>

### <a name="menu">The menu </a>

The menu panel is used to control all features of VR-Cardiomics. It can be moved by grabbing the pink handle on the left side of the menu.

![menu_2](https://user-images.githubusercontent.com/79250095/134443158-cef43273-3223-4d7f-84a3-599a59c64b30.png)

Menu explanations:
1. Inputfield for expression value
2. Switch to current view
3. Enable/Disable the keyboard
4. Make an automated screenshot of the current object
5. Reset the environment
6. Switch to dataset selection menu
7. Switch to settings menu
8. Use the + or - buttons to add or remove objects to the environment
9. Export and Normalised/Absolute toggle button
10. Group Selection


### How to select an expression value

1. By default one model will appear in the envrionment once the application is started. If no model appeared please [add a model](#addmodel) and [select it](#select).
2. Grab the [menu](#menu) panel and touch the inputfield or the keyboard button to enable the keyboard. The menu can be used by either touching the buttons directly or pointing on the button an clicking the *X* button of the Oculus Controller.
3. Enter the name of the expression that should be mapped onto the model. The keyboard can be used by either touching the button directly or pointing on the button an clicking the *X* button of the Oculus Controller.
https://user-images.githubusercontent.com/79250095/134441704-b8db2451-fc6a-4d1b-9400-07ab0c7ded1f.mp4

### <a name="select">How to select a model</a>

### Explode Function

### <a name="addmodel">Add/Remove models</a>

### Change between absolute and normalized expression values

### How to use the heatmap comparision

### Export data/images

### Switch between datasets

### Group Selection

### Additional features


## <a name="custom">Upload custom data </a>

### Upload datasets

### upload 3D model

## <a name="trouble">Troubleshooting </a>
### Oculus Quest/ Quest2
The Oculus Quest and Quest 2 can be used in [Oculus Link](https://www.oculus.com/blog/play-rift-content-on-quest-with-oculus-link-available-now-in-beta/?locale=de_DE) mode. This allows those devices to be treated like an Oculus Rift in wired mode in order to run the application on your local machine rather than on the device itself.  

### VR not working
- If the VR-Headset isn't recognized properly please navigate in Unity from Edit → Project Settings → Player and ensure that *Virtual Reality Supported* is ticked.![VRsupported](https://user-images.githubusercontent.com/79250095/134309050-125952d3-bf16-464e-8f67-9a88e76fb381.png)

- Ensure that Unity runs on the correct platform. Therefore, navigate from File → Build Settings → PC, Mac & Linux Standalone. 
![switchBuild](https://user-images.githubusercontent.com/79250095/134440181-bfbc741d-b01a-4f4d-9bad-ec1d46fe02c3.png)
If the marked Button doesn't appear press the *switch platform* Button.

- VR-Cardiomics is currently only tested for Oculus Rift/ Rift S and Oculus Quest and Quest 2 in link mode. Although, the used plugins allow devices such as HTC Vive to be used they are not tested and therefore not supoorted. Using those devices might led to errors while runing the application.
