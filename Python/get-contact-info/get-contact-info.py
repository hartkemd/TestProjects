
import requests
from bs4 import BeautifulSoup
import re
import csv

def make_phone_dash_delimited(phone):
    return re.sub(r'[^0-9]+', '-', phone)


def format_phone(phone):
    # If the length of the phone number is more than 12
    if len(phone) > 12:
        # If the first two characters are "1-", remove them
        if phone[0:2] == "1-":
            phone = phone[2:]
    # If the string is still longer than 12 characters, remove the characters after the last dash
    if len(phone) > 12:
        index_of_last_dash = phone.rfind('-')
        phone = phone[:index_of_last_dash]
    
    return phone


def get_contact_info(url:str):
    try:
        response = requests.get(url)
        response.raise_for_status()

        soup = BeautifulSoup(response.text, 'html.parser')

        # Find anchor elements with phone numbers
        phone_pattern = re.compile(r'\b(?:\+\d{1,2}\s?)?\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}\b')
        phone_anchors = soup.find_all('a', string=phone_pattern)
        phone_numbers = []
        for anchor in phone_anchors:
            phone = anchor.get_text()
            phone = make_phone_dash_delimited(phone)
            phone = format_phone(phone)
            phone_numbers.append(phone)
        phone_numbers = list(set(phone_numbers))
        phone_numbers.sort()

        # Find anchor elements with email addresses
        email_pattern = re.compile(r'\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b')
        email_anchors = soup.find_all('a', string=email_pattern)
        email_addresses = []
        for anchor in email_anchors:
            email_address = anchor.get_text()
            email_addresses.append(email_address)
        email_addresses = list(set(email_addresses))
        email_addresses.sort()

        return [phone_numbers, email_addresses]
    except requests.exceptions.RequestException as e:
        print(f"Error fetching data from {url}: {e}")
        return None


def write_csv_by_row(url, list:list):

    file_path = "contacts.csv"

    field_names = ["URL", "Phone_Numbers", "Email_Addresses"]

    with open(file_path, mode='w', newline='') as csv_file:
        csv_writer = csv.writer(csv_file)
        csv_writer.writerow(field_names)
        csv_writer.writerow([url, list[0], list[1]])

    print(f"CSV file has been output to {file_path}")


def main():
    urls = ["https://www.tql.com/contact"]

    for url in urls:
        contact_info = get_contact_info(url)
        
        if contact_info:
            print(f"Contact information for {url}: {contact_info}")
            write_csv_by_row(url, contact_info)
        else:
            print(f"Failed to retrieve contact information for {url}")

if __name__ == "__main__":
    main()
