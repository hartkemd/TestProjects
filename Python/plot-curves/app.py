# Import libraries
import matplotlib.pyplot as plt
import numpy as np

# Creating vectors x and y
x = np.linspace(0, 4)
y = 7 - 1.5*x

fig = plt.figure(figsize = (8, 5))
# Create the plot
plt.plot(x, y)

# Label plot
plt.xlabel('Quantity (5 oz.)')
plt.ylabel('Price ($)')
plt.title('Demand')

# Show the plot
plt.show()
