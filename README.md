# microbit-motion-capture
Can we use micro:bits to do motion capture in Blender?! let's find out...

## Structure
<img width="1039" height="796" alt="{BEC273D3-4122-450E-825B-ED9F14D56532}" src="https://github.com/user-attachments/assets/0c1387bf-ef17-475d-96a1-b895ec861b7e" />

### Detecting and sending accelerometer values via radio
Multiple battery powered micro:bits could be strapped to different limbs. Each one can be assigned a unique ID and be made to transmit accelerometer values for X, Y and Z.

Relevant file: `microbit/sensor.py`

### Receiving accelerometer values and streaming rotation / position
One micro:bit could be connected ot a PC via USB and be used to receive accelerometer values transmitted from all of the other micro:bits and display the received data via the REPL. 

Relevant file: `microbit/receiver.py`

A C# WinForms application could then connect to the receiver micro:bit via the USB serial port and read any received data from the REPL. 
This data would need to be processed to:
- remove noise
- detect acceleration due to gravity and calculate rotation
- remove acceleration due to gravity and calculate change in position
It would then stream rotation and position data via UDP so that anyone on the same network could receive motion capture data from any detected micro:bit
Ideally it would also visualise the data for each micro:bit motion used for motion capture as a live line graph for each of X, Y and Z

### Controlling 3d objects in Blender
A python plugin for Blender would connect to the C# WinForms app and allow you to control the position and / or rotation of any 3d object. Different 3d objects should be controllable by different micro:bits


