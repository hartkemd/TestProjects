import tkinter as tk

# Create the main tkinter window
root = tk.Tk()
root.title("Scrollable Listbox")

# Create a Scrollbar widget
scrollbar = tk.Scrollbar(root)
scrollbar.pack(side=tk.RIGHT, fill=tk.Y)

# Create the Listbox widget and configure its yscrollcommand
listbox = tk.Listbox(root, yscrollcommand=scrollbar.set)
listbox.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)

# Configure the scrollbar's command
scrollbar.config(command=listbox.yview)

# Add items to the Listbox
for i in range(1, 101):
    listbox.insert(tk.END, f"Item {i}")

# Start the tkinter main loop to display the window
root.mainloop()
