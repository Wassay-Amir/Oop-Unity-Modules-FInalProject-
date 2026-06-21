# OOP Final Project: Physics Lab Simulation

##  Complete Project Overview

A comprehensive **Unity-based Physics Laboratory Simulation** project containing multiple electrical components and a complete **Ohm's Law Verification Practical** in VR.

**Status:**  All Modules Complete | Integration & Polish Ongoing
**Grade Level:** Grade 10 Physics
**Framework:** Unity 2020.3+

---

##  Project Modules (5 Total)

### **Module 1: Battery / Power Supply** 
**Status:**  Complete

A basic battery/power supply component that provides voltage to the circuit.

**Features:**
- ON/OFF toggle (Keyboard: C/D)
- Visual indicator light (glows when ON)
- 3D model with terminals
- Emission-based feedback
- Reusable prefab

**Files:**
- `BatteryController.cs`
- `Battery.prefab`
- Materials and 3D model

**What Works:**
-  ON/OFF functionality
-  Visual feedback with glow
-  Keyboard controls

**What's Missing:**
-  Voltage value display
-  Circuit integration
-  Automatic connection detection

---

### **Module 2: Voltmeter** 
**Status:**  Complete

A digital voltmeter that measures voltage difference across components.

**Features:**
- Digital voltage display (0-15V)
- Positive and negative terminals
- Instruction panel with manual
- Reusable prefab
- Real-time voltage reading

**Files:**
- `Voltmeter.cs`
- `Terminal.cs`
- `ManualUI.cs`
- `Voltmeter.prefab`
- 3D model and display

**What Works:**
-  Displays voltage readings
-  Terminal system
-  Instruction manual popup
-  Clean digital interface

**What's Missing:**
-  Wire connection system
-  Automatic voltage calculation
-  Snap-to-wire functionality
---

### **Module 3: Ammeter** 
**Status:**  Complete

A digital ammeter that measures current flowing through the circuit.

**Features:**
- Digital current display (0-0.6A)
- Positive and negative terminals
- Instruction panel with manual
- Series connection ready
- Real-time current reading

**Files:**
- `Ammeter.cs`
- `Terminal.cs`
- `ManualUI.cs`
- `Ammeter.prefab`
- 3D model and display

**What Works:**
-  Displays current readings
-  Terminal system
-  Instruction manual popup
-  Series connection ready

**What's Missing:**
-  Wire connection system
-  Automatic current calculation
-  Snap-to-wire functionality

---

### **Module 4: Switch** 🔌
**Status:**  Complete

An interactive on/off switch for controlling circuit flow.

**Features:**
- Click to toggle ON/OFF
- Smooth lever rotation
- Color feedback (yellow = OFF, red = ON)
- Implements IElectricalComponent interface
- Grabbable and placeable

**Files:**
- `Switch.cs`
- `IElectricalComponent.cs`
- `Switch.prefab`
- Materials

**What Works:**
-  Toggle functionality
-  Rotation animation
-  Color feedback
-  Circuit integration
-  Grab mechanics

**What's Missing:**
-  Sound effects
-  Advanced animations

---

### **Module 5: Rheostat** 
**Status:**  Complete

A variable resistor (0-100Ω) for adjusting circuit resistance.

**Features:**
- Sliding mechanism
- Real-time resistance display
- Auto-calculates R = V/I
- Physics-based movement
- Grabbable and placeable

**Files:**
- `Rheostat.cs`
- `Rheostat.prefab`
- Materials and components

**What Works:**
-  Smooth sliding
-  Resistance calculation
-  Circuit integration
-  Auto R = V/I
-  Grab mechanics

**What's Missing:**
-  Visual needles
-  Sound effects
-  Smooth animations

---

##  Complete Practical: Ohm's Law Verification VR Lab

**Integrates All 5 Modules**

A complete VR physics lab where students perform the **Grade 10 Physics Practical 14.1: Verify Ohm's Law using Nichrome Wire**.

**See:** `PRACTICAL-README.md` for detailed information

**Quick Stats:**
-  8 core scripts
-  6 prefabs
-  5 modules integrated
-  First-person VR environment
-  Data recording system
-  Live meter readings (in progress)
-  Graph plotting (in progress)

---

##  Project Structure

---

##  Module Comparison Table

| Feature | Battery | Voltmeter | Ammeter | Switch | Rheostat |
|---------|---------|-----------|---------|--------|----------|
|  Status | Complete |  Complete |  Complete |  Complete |  Complete |
| **3D Model** |  Yes |  Yes |  Yes |  Yes |  Yes |
| **Display/UI** |  Yes |  Yes |  Yes |  Partial |  Partial |
| **Scripts** | 1 | 3 | 3 | 2 | 1 |
| **Prefab** |  Yes |  Yes |  Yes |  Yes |  Yes |
| **Grab Mechanic** |  No |  No |  No |  Yes |  Yes |
| **Circuit Integration** |  Partial |  Partial |  Partial |  Full |  Full |
| **Working Demo** | Yes |  Yes |  Yes |  Yes |  Yes |

---

---

##  Project Statistics

| Metric | Value |
|--------|-------|
| Total Modules | 5 |
| Total Scripts | 18+ |
| Total Prefabs | 6 |
| Lines of Code | 2000+ |
| Development Time | 30+ hours |
| Features Implemented | 85% |
| Features Planned | 100% |

---

##  What's Complete

-  All 5 modules built and tested
-  Complete VR lab practical
-  Grab & place mechanics
-  Data recording system
-  Instructions panel
-  Auto R = V/I calculation
-  APK builds available
-  WebGL builds available
-  Module prefabs created
-  Documentation written

---

##  What's Missing

**High Priority:**
-  Live voltmeter/ammeter readings in practical
-  V vs I graph generation
-  Circuit connection validation

**Medium Priority:**
-  Wire connection system (for modules)
-  Sound effects
-  Advanced animations

**Low Priority:**
-  Haptic feedback
-  Advanced UI polish
-  Multiple difficulty levels

---

##  Documentation

Each component has detailed documentation:

1. **Module READMEs** - See individual module folders
2. **Practical README** - See `PRACTICAL-README.md`
3. **Progress Report** - See `ProgressDone.txt`
4. **Code Comments** - Inline documentation in scripts

---

##  Demos & Builds

**Available:**
-  Module demo videos (3 min each)
-  Practical demo video (5 min, sped up)
-  Android APK builds
-  WebGL web builds

---

---

##  Learning Outcomes

Students will understand:
- Ohm's Law and its applications
- Voltage, current, and resistance
- Series circuits
- How to use measurement instruments
- Experimental procedure
- Data analysis and graphing

---

##  Credits

**Created:** June 2026

**Institution:** ITU (Information Technology University)
**Course:** OOP Final Project

**Based on:**
- Grade 10 Physics Practical 14.1
- Pakistani Physics Curriculum

**All modules and practical are ready for submission!** 

See individual folders for module-specific information.
