import random

def print_choices(choices):

    sum_of_choices = ""

    for index, choice in enumerate(choices, start=1):
        if index != len(choices):
            sum_of_choices += choice + ", "
        else:
            sum_of_choices += choice
    
    print(sum_of_choices)


def assemble_string(choices):
    
    choices_count = len(choices)
    choices_string = ""

    for index in range(1, choices_count + 1):
        if index != (choices_count):
            choices_string += str(index) + ", "
        else:
            choices_string += str(index)

    return choices_string


def get_valid_choice(choices, prompt):
    
    isValid = False

    choices_string = assemble_string(choices)
    prompt = f" {prompt} ({choices_string}): "
    choices_count = len(choices)

    while(not isValid):
        user_input = input(prompt)

        # Validate integer
        try:
            number = int(user_input)

        except ValueError:
            print("Invalid input. Please enter a valid integer.")
            continue

        # Validate range
        if (number < 1 or number > choices_count):
            print(f"Invalid input. Please enter an integer between 1 and {choices_count}.")
        else:
            isValid = True
    
    return number


def enter_mine():
    print("You have entered the mine.")
    print("Three veins lay ahead.")
    choices = ["1 = swing pickaxe", "2 = exit mine"]
    print_choices(choices)
    choice = get_valid_choice(choices, "What will you do?")
    if choice == 1:
        swing_pickaxe()


def get_random():
    number = random.randint(1, 100)
    return number


def print_stats(ore_count, rock_count, swing_count):
    print(f"You mined {ore_count} ores and {rock_count} rocks out of {swing_count} swings.")


def swing_pickaxe():
    
    ore_count = 0
    rock_count = 0
    swing_count = 0
    isHit = False
    hit_roll = get_random()
    choice = 1

    if hit_roll > 10:
        isHit = True

    while (choice == 1):
        swing_count += 1
        if isHit:
            print("You hit the vein!")
            ore_roll = get_random()
            if ore_roll > 70:
                ore_count += 1
                print("You got an ore!")
            else:
                rock_count += 1
                print("You got some rocks.")
        else:
            print("You missed.")
        choices = ["1 = yes", "2 = no"]
        print_choices(choices)
        choice = get_valid_choice(choices, "Keep swinging?")

    print_stats(ore_count, rock_count, swing_count)


choices = ["1 = enter mine", "2 = quit"]
print_choices(choices)
choice = get_valid_choice(choices, "What will you do?")
if choice == 1:
    enter_mine()
print("Goodbye.")
