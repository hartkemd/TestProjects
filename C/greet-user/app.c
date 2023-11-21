#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define MAX_CHARS_IN_NAME 20
#define MAX_CHARS_IN_INPUT 50
#define FALSE 0
#define TRUE 1

char* getNameFromUser();
int isInputValid(char input[]);
int isWhitespace(char c);
void removeWhitespace (char* input, char* output);
void greetUser(char name[]);

void main() {
	char name[MAX_CHARS_IN_NAME + 1];

	strcpy(name, getNameFromUser());
	greetUser(name);
}

char* getNameFromUser() {

	char userInput[MAX_CHARS_IN_INPUT + 1];
	char name[MAX_CHARS_IN_NAME + 1];
	int inputIsValid = FALSE;

	while(inputIsValid == FALSE) {
		printf("Please enter your first name: ");
		fgets(userInput, sizeof(userInput), stdin);
		removeWhitespace(userInput, name);
		inputIsValid = isInputValid(name);
	}

	return strdup(name);
}

int isInputValid(char input[]) {

    int output = FALSE;

    size_t len = strlen(input);

    if (len <= 0) {
        printf("Name cannot be empty. Please try again.\n");
    }
    else if (len > MAX_CHARS_IN_NAME) {
        printf("The maximum characters allowed for a name is %d. Please try again.\n", MAX_CHARS_IN_NAME);
    }
    else {
        output = TRUE;
    }

    return output;
}

int isWhitespace(char c) {
    return (c == ' ' || c == '\t' || c == '\n' || c == '\r');
}

void removeWhitespace (char* input, char* output) {

    int indexOfOutput = 0;

    while ((*input != '\0') && (indexOfOutput < MAX_CHARS_IN_INPUT - 1)) {
        if (isWhitespace(*input) == FALSE) {
            output[indexOfOutput] = *input;
            indexOfOutput++;
        }
        input++;
    }

    output[indexOfOutput] = '\0';
}

void greetUser(char *name) {
	printf("Hello, %s!\n", name);
}
