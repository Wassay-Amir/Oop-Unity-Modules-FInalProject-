Unity Physics Lab Project - Battery / Power Supply Module

----------------------------------------
PROJECT OVERVIEW
----------------------------------------
This project is a Unity-based simulation of a basic battery / power supply used in a physics laboratory. 
It is designed as a modular component that can later be integrated with other electrical components 
such as switches, voltmeters, and bulbs.

----------------------------------------
COMPONENTS USED
----------------------------------------
1. Battery Body (Cylinder)
2. Positive Terminal
3. Negative Terminal
4. Indicator Light (Sphere)

----------------------------------------
FUNCTIONALITY IMPLEMENTED
----------------------------------------
- The battery can be turned ON and OFF using keyboard input.

Controls:
- Press 'C' → Battery ON
- Press 'D' → Battery OFF

- When the battery is ON:
  → The indicator light glows (green emission enabled)

- When the battery is OFF:
  → The indicator light turns OFF (no emission)

- The system uses Unity scripting (C#) to control:
  → Material emission
  → Real-time user input

----------------------------------------
WORKING LOGIC
----------------------------------------
- A script (BatteryController) is attached to the battery object.
- The script detects keyboard input.
- Based on input:
  → It enables or disables emission on the indicator light material.

----------------------------------------
COMPLETED FEATURES
----------------------------------------
✔ Basic 3D battery model
✔ Indicator light system
✔ ON/OFF control using keyboard
✔ Visual feedback using glow (emission)
✔ Script integration with Unity objects

----------------------------------------
MISSING / FUTURE IMPROVEMENTS
----------------------------------------
✘ No wire connection system yet
✘ No real circuit simulation (current/voltage flow)
✘ No interaction with other components (bulb, switch, voltmeter)
✘ No UI controls (buttons/sliders)
✘ No automatic detection of connections
✘ No voltage 


AUTHOR
---------------------------------------
Shahzaib

----------------------------------------
PROJECT TYPE
----------------------------------------
Semester Project - Unity Physics Lab Simulation