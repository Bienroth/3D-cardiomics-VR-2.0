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

The menu panel is used to control all features of VR-Cardiomics. It can be moved by grabbing the pink handle on the left side of the menu. The menu can be used by either touching the buttons directly or pointing on the button an clicking the *A* button of the primary Oculus Controller.

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


### <a name="selectExpression">How to select an expression value </a>

1. By default one model will appear in the envrionment once the application is started. If no model appeared please [add a model](#addmodel) and [select it](#select).
2. Grab the [menu](#menu) panel and touch the inputfield or the keyboard button to enable the keyboard. The menu can be used by either touching the buttons directly or pointing on the button an clicking the *A* button of the primary of the Oculus Controller.
3. Enter the name of the expression that should be mapped onto the model. The keyboard can be used by either touching the button directly or pointing on the button an clicking the *X* button of the Oculus Controller.

https://user-images.githubusercontent.com/79250095/134448551-48a56437-dcbd-42c8-abf5-e7edf90579ef.mp4

### <a name="select">How to select a model</a>

By default the first model in the environemnt is selected. If new models will be added select them using the *hihghlighter function*. This function is enbaled by pressing the *Y* Button of the secondary controller. A red illuminating circle will appear under the selected model. Press the *Y* button again to toggle to the next model. Press *A* on the primary controller to select the current model.

https://user-images.githubusercontent.com/79250095/134447783-f0fbcc7f-b97d-4747-908d-103cc33a71ca.mp4

### Explode Function
The explode function will expand the model based on it's hierarchy. this feature might not work properly for custom objects. To toggle between the normal view and the exploded view press the *X* button on the secondary controller. Only the [selected model](#select) will be expanded.

![Screenshot (238)](https://user-images.githubusercontent.com/79250095/134447818-21544de8-5dd4-4689-834d-6c8a84e938db.png)

### <a name="addmodel">Add/Remove models</a>

VR-Cardiomics allows adding multiple objects to the environment to map expression data onto it. Use the [menu panel](#menu) to add or remove models by pressing either the + or the - button. Keep in mind that always the last model will be deleted once the - button is pressed. The number between the buttons shows how many active objects are currently in the surrounding.

https://user-images.githubusercontent.com/79250095/134448305-e560c958-9470-4d4a-9885-8e2b54f4ad0b.mp4

### Change between absolute and normalized expression values

VR-Cardiomics allows to present expression data either in absolute or in normalised values. Our example data is based on log2CPM values for absolute. If [own datatsets](#custom) are used, the absolute values will represent the uploaded values of the csv file. Toggle between Normalised or Absolute by using the [menu panel (9)](#menu).

### How to use the heatmap comparision

The heatmap comparision is a useful feature to allow calculating the absolute differences of each piece of the object between two expression patterns. The feature will automatically calculate those differences and apply a new colourisation to the model regarding how big the differences in each selected piece are. In order to use the heatmap function just select a expression for two objects and then grab one model with the pink handle. Hold the pink handle onto the handle of a second heart model. Release the trigger Button to enable the heatmap feature.

https://user-images.githubusercontent.com/79250095/134449147-5b535342-94d6-43f2-9e9e-18d4f53ccc0e.mp4

### Export data/images

VR-Cardiomics allows to export data during runtime. 

1. **Making screenshots** → Simply use the Camera button of the [menu panel(4)](#menu). A Screenshot of the current selected heartmodel will be saved to your local machine. 
2. **Exporting Similar Expressions** → If a expression value is [selected](#selectExpression) a list of similar expressions will be calculated based on the selection. This list can be exported as a csv file using the export button on the [menu panel (9)](#menu). This CSV file is then saved in the Asset folder of Unity. (Figure: SimilarGenes.txt → blue).
3. **Logfile** → For each session a logfile will be created to keep track of everything you did during your session. This logfile is saved automatically on your local machine within the Assets folder of Untiy (Figure: SessionLog.txt → green).

![exportFiles](https://user-images.githubusercontent.com/79250095/134449902-41210806-428f-4381-a907-b7e520b89ce5.png)

### Switch between datasets

VR-Cardiomics allows to upload [own datasets](#custom) with expression values. You can also upload multiple datasets and switch between them during runtime. Therfore navigate to the datset menu by pressing the dataset button of the [menu panel(6)](#menu). Touching your pre-loaded dataset forces a reset of the environemnt with the new dataset beeing used. 

https://user-images.githubusercontent.com/79250095/134450769-7be16fa7-0056-41fb-aeaf-7ddb5b059641.mp4

### Piecewise Comparison / Group Selection

The *piecewise comparison/ group selection* is a feature that allwos to group a number of pieces of the object together in two groups. Based on those two groups a list of expression values is generated matching the pattern of the selected pieces. 
To use this feature press the *group Selection* Button on the [menu panel(10)](#menu). All objects will be deleted except of one object. This object can be used to select the pieces of the first group. Just bring the controller at one piece and press the *A* button of the oculus controller to select the piece. The piece will be coloured to confirm the selection. continue with this step until all pieces of group 1 are selceted. Now push the button of the [menu panel(10)](#menu) again to confirm the first group and start selecting new pieces for group 2. If the selection is done just press the button of the [menu panel(10)](#menu) again to confirm selection and start calculating the matching expression values. The results will be shown in the table below. 
To deselect pieces from the selection just select them anew.

https://user-images.githubusercontent.com/79250095/135013053-277ebcd8-6a62-445a-b468-9fe83173c376.mp4

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
