# Lane-Detection-And-Data-Generation-For-Self-Driving-Car

## Overview
This code is for Lane Detection and Data Generation, which is going to be used in self driving car project.
It has a simple pipeline, to detect road lines in a frame, through a camera, which is mounted on the hood of the car in Unity3D Simulator. The Steering Angle, Velocity, and Throttle of the car is saved in a csv file, corresponding to each frame, along with the local directory of all images.

## Dependencies
You can install depedencies by running the following command in Anaconda prompt:
```
# Opencv2
conda install -c conda-forge opencv
```

Also, you need to have Unity3D game engine, which can be downloaded from [here](https://unity3d.com/)

## Working with Unity3D Game Engine.
1) Launch Unity3D Game Engine.
2) Select "Open Project", select "SDC Lane Detection And Data Generation", from this project.
3) Your project will open in Unity3D.

## Workflow
1) In "Data Generation.py" file, change the directory, where the csv file is going to be saved.
2) In "Data Generation.py" file, change the directory, where all your images will be going to be saved.
3) Now, run the Unity3D Simulator.
4) Then, Run the python script, Data Generation.py.
5) Then, start driving the car manually, using keyboard or joystick.

## Screenshots
![sdccar](![314](https://user-images.githubusercontent.com/31696557/135906985-01032fed-cbdb-45a9-95ff-d7504a3c064f.png))


![wasil108](https://user-images.githubusercontent.com/31696557/39653814-0dfca2ae-5010-11e8-94b0-562c67afd726.png)
![capture](https://user-images.githubusercontent.com/31696557/39654354-11f0449a-5012-11e8-9112-7cf083a5b7d6.PNG)



