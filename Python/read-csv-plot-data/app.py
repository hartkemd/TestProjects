import pandas as pd
import matplotlib.pyplot as plt
from matplotlib.ticker import FuncFormatter
import numpy as np

def format_thousands(value, pos):
    return "{:,.0f}".format(value)

year_range = np.arange(2017, 2022, 1)

df = pd.read_csv('sample-data.csv')

# Create three figures
fig1, ax1 = plt.subplots()
fig2, ax2 = plt.subplots()
fig3, ax3 = plt.subplots()

# Plot data on each figure
ax1.plot(df.year, df.establishments)
ax1.set_title('Establishments by Year')
ax1.set_xlabel('Year')
ax1.set_xticks(year_range)
ax1.set_ylabel('Establishments')

ax2.plot(df.year, df.employees)
ax2.set_title('Employees by Year')
ax2.set_xlabel('Year')
ax2.set_xticks(year_range)
ax2.set_ylabel('Employees')
ax2.yaxis.set_major_formatter(FuncFormatter(format_thousands))

ax3.plot(df.year, df.annual_payroll)
ax3.set_title('Annual Payroll by Year')
ax3.set_xlabel('Year')
ax3.set_xticks(year_range)
ax3.set_ylabel('Annual Payroll ($)')
ax3.yaxis.set_major_formatter(FuncFormatter(format_thousands))

# Adjust layout to prevent overlap
plt.tight_layout()

# Show all three figures in the same window
plt.show()
