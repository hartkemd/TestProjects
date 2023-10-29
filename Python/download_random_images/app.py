import requests
import random
import os

# Number of random images you want to download
num_images = 12

# Directory where you want to save the downloaded images
download_dir = 'downloaded_images/'

# Create the download directory if it doesn't exist
os.makedirs(download_dir, exist_ok=True)

# Function to download a random image from Lorem Picsum
def download_random_image():
    image_id = random.randint(1, 1000)  # Lorem Picsum provides images with IDs from 1 to 1000
    image_url = f'https://picsum.photos/1920/1080/?image={image_id}'
    response = requests.get(image_url)
    if response.status_code == 200:
        # Generate a unique filename using the image's ID
        filename = f'{download_dir}{image_id}.jpg'
        with open(filename, 'wb') as file:
            file.write(response.content)
            print(f'Downloaded: {filename}')
    else:
        print('Failed to download image.')

# Download the specified number of random images
for _ in range(num_images):
    download_random_image()

print('Downloaded all random images!')
