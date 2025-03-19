	*Cost-2100 Path Loss Calculator*

	-This app Assumes the use of isotropic antennas ONLY for the calculation of path loss.

	-MmWave frequency is not yet supported in this project.

	-Clutter factor provides an additional parameter (besides Environment Constants) to calibrate the model against real-world data further,ensuring it produces more accurate results.

	-Once the clutter adjustment is calculated, it is added to the pathLoss, effectively increasing the path loss value, reflecting the additional obstacles and interference in the environment.

	-Clutter factor does not necessarily needs an input.If intentionally left blank it will be automatically be assigned as 0.1 which means minimum influence but still an additional adjustment to the path loss calculation.

	-Valid Frequencies   { 800, 850, 900, 1800, 1900, 2100,2300, 2400, 2600, 3300, 3500, 3700, 4500, 4800, 5000, 5200, 5500, 5800, 5900, 6000 }.


