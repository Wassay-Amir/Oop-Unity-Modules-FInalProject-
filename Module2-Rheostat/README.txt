# Rheostat Module

## Description
A variable resistor (rheostat) component that allows users to adjust resistance values in a circuit. The rheostat uses a sliding mechanism to change resistance from 0 to maximum value (default: 100Ω).

## Features
- **Sliding Mechanism** - Smooth vertical slider to adjust resistance
- **Real-time Value Display** - Shows current resistance as you drag
- **Resistance Calculation** - Automatically calculates R = V/I when connected to circuit
- **Circuit Integration** - Implements IElectricalComponent interface
- **Physics-based** - Uses Rigidbody for realistic movement
- **Drag Mechanics** - Pick up and move in VR environment
- **Material Feedback** - Visual color indication

## Technical Specifications

### Resistance Range
- **Minimum Resistance:** 0Ω
- **Maximum Resistance:** 100Ω (configurable in Inspector)
- **Default Position:** Middle (50Ω)

### Components
- **RailBase** - The stationary track (dark gray)
- **Slider** - The moving knob (blue/colored)
- **Sphere Knob** - Visual indicator at top

### Script Files
- `Rheostat.cs` - Main rheostat controller
- `IElectricalComponent.cs` - Interface for circuit components
- `Circuit.cs` - Circuit manager (for integration)

## How to Use

### In Unity Editor

1. **Import Prefab:**
   - Drag `Rheostat.prefab` into your scene

2. **Configure in Inspector:**
   - **Max Resistance:** Set maximum value (default: 100)
   - **Min Y:** Bottom position of slider (-1.5)
   - **Max Y:** Top position of slider (1.5)

3. **Connect to Circuit:**
   - Ensure `Circuit.cs` is in your scene
   - Rheostat will auto-register with circuit

### During Gameplay

1. **Hover over rheostat** - It highlights
2. **Click and drag** - Move slider up/down
3. **Release** - Slider stays at position
4. **Resistance updates** - Real-time value display

## How It Works

### Resistance Calculation