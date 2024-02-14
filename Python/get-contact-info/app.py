
import requests
from bs4 import BeautifulSoup

def get_contact_info(url):
    try:
        response = requests.get(url)
        response.raise_for_status()

        soup = BeautifulSoup(response.text, 'html.parser')

        # Assuming the contact information is within a specific HTML tag, adjust as needed
        contact_info = soup.find('div', class_='contact-info').get_text()

        return contact_info
    except requests.exceptions.RequestException as e:
        print(f"Error fetching data from {url}: {e}")
        return None

def main():
    # List of URLs to scrape
    urls = ["https://example.com/page1", "https://example.com/page2"]

    for url in urls:
        contact_info = get_contact_info(url)
        
        if contact_info:
            print(f"Contact information for {url}: {contact_info}")
        else:
            print(f"Failed to retrieve contact information for {url}")

if __name__ == "__main__":
    main()
