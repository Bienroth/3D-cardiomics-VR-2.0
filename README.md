# VR-Cardiomics

## Overview

VR-Cardiomics provides a framework to map multi-dimensional data (such as intensity and location of gene expression) on to 3D models in a heatmap-like manner. In our use case the intensity is the level of gene expression of those expressed in the adult heart, and the location is this expression level in 18 discrete pieces of the heart as measured by RNA-seq.

Code for the manuscript: Denis Bienroth<sup>\*</sup>, Hieu T. Nim, Dimitar Garkov, Karsten Klein, Sabrina Jaeger-Honz, Mirana Ramialison<sup>#</sup> and Falk Schreiber<sup>#</sup>. "Spatially-Resolved Transcriptomics in ImmersiveEnvironments" (<sup>\*</sup>: first author; <sup>#</sup>: corresponding authors)

VR-Cardiomics is designed to map user generated data onto a user specific 3D model. However, the data and the model must meet certain requirements. Please refer to the chapter #Upload Custom Data for more information on how to use VR-cardiomics as a framework for own data and models on your local machine.

This application supports VR devices as listed below, our [web application](https://github.com/Ramialison-Lab/3DCardiomics) and [zSpace](https://github.com/Ramialison-Lab/3DCardiomicsZSpace) are available as well.

## Dependencies

-   Unity (2019.4.19f1)

Currently fully supported VR devices include: 
-  	Oculus Quest / Quest 2 (Link mode)
-	Oculus Rift / Rift S 
Other devices may not be fully supported.

## How to run VR-Cardiomics

The simplest way to run VR-Cardiomics is by using Unity [2019.4.19f1](https://unity3d.com/de/unity/whats-new/2019.4.19). Copy VR-Cardiomics from github to your local machine ([how to copy from github](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)) and open it in Unity (Information on how to open an exisiting project in Unity can be found [here](https://docs.unity3d.com/2019.1/Documentation/Manual/GettingStartedOpeningProjects.html)).

*It is recommended to ignore update notifications from Unity in order to ensure that the application is processed as expected.*

## VR-Cardiomics Features

### How to select an expression value

### How to select a model

### Explode Function

### Add/Remove models

### Change between absolute and normalized expression values

### How to use the heatmap comparision

### Export data/images

### Switch between datasets

### Additional features


## Upload custom data

### Upload datasets

### upload 3D model

## Troubleshooting
### Oculus Quest/ Quest2
The Oculus Quest and Quest 2 can be used in [Oculus Link](https://www.oculus.com/blog/play-rift-content-on-quest-with-oculus-link-available-now-in-beta/?locale=de_DE) mode. This allows those devices to be treated like an Oculus Rift in wired mode in order to run the application on your local machine rather than on the device itself.  

### VR-Headset not recognized
If the VR-Headset isn't recognized properly please navigate in Unity from Edit → Project Settings → Player and ensure that *Virtual Reality Supported* is ticked.![VRsupported](https://user-images.githubusercontent.com/79250095/134309050-125952d3-bf16-464e-8f67-9a88e76fb381.png)

