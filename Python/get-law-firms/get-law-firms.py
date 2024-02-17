
import requests
from bs4 import BeautifulSoup

def get_law_firm_names(url:str):
    try:
        response = requests.get(url)
        response.raise_for_status()

        soup = BeautifulSoup(response.text, 'html.parser')

        names = soup.find_all('li', class_='detail_title')

        return names
    except requests.exceptions.RequestException as e:
        print(f"Error fetching data from {url}: {e}")
        return None


def main():
    url = "https://www.martindale.com/whistleblower-litigation-lawyers/new-york/new-york/"

    names = get_law_firm_names(url)
    
    if names:
        print("Law Firm Names:")
        for name in names:
            print(name)
    else:
        print(f"Failed to retrieve information from {url}")


if __name__ == "__main__":
    main()
