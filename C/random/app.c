#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>

char getRandom() {
    // Seed the random number generator with the current time
    srand(time(NULL));

    // Define the range (min and max values)
    char min = 1;
    char max = 6;

    // Generate and print random number within the specified range
    char randomNumber = rand() % (max - min + 1) + min;

    return randomNumber;
}

void printResult(char number) {
    if (number == 1) {
        printf("Uh oh! You rolled a 1. Critical failure!\n");
    }
    else if (number > 1 && number < 6) {
        printf("You rolled a %d.\n", number);
    }
    else if (number == 6) {
        printf("Wow! You rolled a 6. Critical success!\n");
    }
}

int getNumberFromUser() {
    char userInput[3];
    char *endptr;
    int number;
    int isValid = 0;

    while (isValid == 0) {
        printf("How many times do you want to roll? (min 0, max 9) ");
        fgets(userInput, sizeof(userInput), stdin);

        // Remove newline character
        if (userInput[strlen(userInput) - 1] == '\n') {
            userInput[strlen(userInput) - 1] = '\0';
        }

        int result = sscanf(userInput, "%d", &number);
        
        // Convert string to int
        if (result != 1 || number < 0 || number > 9) {
            isValid = 0;
            printf("Invalid input. Please enter a valid number between 0 and 9.\n");
        } else {
            isValid = 1;
        }
    }

    return number;
}

int main() {
    int numberOfTimes = getNumberFromUser();
    printf("You would like to roll %d times.\n", numberOfTimes);
    // char number = getRandom();
    // printResult(number);

    return 0;
}
