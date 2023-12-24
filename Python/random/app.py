import random
import time

def get_randoms(times_to_roll):
    # random.seed(time.time())
    numbers = random.sample(range(1, 6 + 1), times_to_roll)

    return numbers

def print_results(numbers):
    roll_message = "* Die roll"

    for index, number in enumerate(numbers, start=1):
        if (number == 1):
            print(f"{roll_message} {index}: 1 - Critical failure!")
        elif (number > 1 and number < 6):
            print(f"{roll_message} {index}: {number}")
        elif (number == 6):
            print(f"{roll_message} {index}: 6 - Critical success!")

def get_and_validate_input():
    number = -1
    isValid = False

    while(not isValid):
        user_input = input("How many times do you want to roll? (0-9): ")

        # Validate integer
        try:
            number = int(user_input)

        except ValueError:
            print("Invalid input. Please enter a valid integer.")
            continue

        # Validate range
        if (number < 0 or number > 9):
            print("Invalid input. Please enter an integer between 0 and 9.")
        else:
            isValid = True
    
    return number

def roll_dice(times_to_roll):
    my_numbers = get_randoms(times_to_roll)
    print_results(my_numbers)

def display_welcome():
    print("Welcome to my 6-sided die app!")

def display_closing():
    print("Thanks for playing!")

display_welcome()
times_to_roll = get_and_validate_input()
roll_dice(times_to_roll)
display_closing()
