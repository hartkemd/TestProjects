#include <stdio.h>
#include <stdlib.h>
#include <time.h>

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

char getNumberFromUser() {
    char userInput[2];
    char *endptr;
    char number;
    char isValid = 0;

    while(isValid == 0) {
        printf("How many times do you want to roll? (min 0, max 9) ");
        fgets(userInput, sizeof(userInput), stdin);

        // Convert string to long
        number = strtol(userInput, &endptr, 10);

        // Check for conversion errors
        if (*endptr != '\0' && *endptr != '\n') {
            isValid = 0;
            printf("Conversion error: %s\n", endptr);
        } else {
            isValid = 1;
            // printf("Parsed number: %d\n", number);
        }
    }

    return number;
}

int main() {
    char numberOfTimes = getNumberFromUser();
    printf("You would like to roll %d times.\n", numberOfTimes);
    // char number = getRandom();
    // printResult(number);

    return 0;
}
