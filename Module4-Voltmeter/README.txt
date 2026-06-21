Description:
This prefab represents a digital voltmeter designed for Unity-based electrical circuit simulations. It measures the voltage difference between two circuit nodes and displays the value on a digital screen.

Included Components:
- Voltmeter.prefab
- Voltmeter.cs
- Terminal.cs
- ManualUI.cs
- 3D Body Model
- Positive Terminal (+)
- Negative Terminal (-)
- Digital Display
- Help/Instruction Button
- Instruction Panel

How It Works:
Voltage = PositiveTerminal.Voltage - NegativeTerminal.Voltage

Usage:
1. Place the Voltmeter prefab into the scene.
2. Connect the Positive Terminal to the positive node of the circuit.
3. Connect the Negative Terminal to the negative node of the circuit.
4. Ensure the circuit simulation updates the terminal voltage values.
5. Run the simulation.

Expected Inputs:
PositiveTerminal.Voltage
NegativeTerminal.Voltage

Output:
Displayed Voltage Reading (V)

Included Features:
- Digital voltage display
- Reusable prefab
- Positive and negative terminals
- Instruction manual popup
- Compatible with external wire systems

Not Included:
- Wire connection system
- Circuit solver
- Battery simulation
- Automatic voltage calculation
- Snap-to-wire functionality
- Electrical physics engine


