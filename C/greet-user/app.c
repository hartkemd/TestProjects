#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define MAX_CHARS_IN_NAME 20
#define FALSE 0
#define TRUE 1

char* getNameFromUser();
int isInputValid(char input[]);
char* removeWhitespace(char input[]);
void removeWhitespaceRecursive(char input[], char output[], int index, int outIndex);
int isWhitespace(char c);
void greetUser(char name[]);

int main() {
	char name[MAX_CHARS_IN_NAME];

	strcpy(name, getNameFromUser());
	greetUser(name);

	return 0;
}

char* getNameFromUser() {
	size_t len = 0;
	char userInput[50];
	int inputIsValid = FALSE;

	while(inputIsValid == FALSE) {
		printf("Please enter your first name: ");
		fgets(userInput, sizeof(userInput), stdin);
		len = strlen(userInput);
		userInput[len - 1] = '\0'; // Remove the newline character
        strcpy(userInput, removeWhitespace(userInput));
		len = strlen(userInput);
		inputIsValid = isInputValid(userInput);
	}

	return strdup(userInput);
}

int isInputValid(char input[]) {
    size_t len = strlen(input);

    if (len <= 0) {
        printf("Name cannot be empty. Please try again.\n");
        return FALSE;
    }
    else if (len >= MAX_CHARS_IN_NAME) {
        printf("The maximum characters allowed for a name is %d. Please try again.\n", MAX_CHARS_IN_NAME);
        return FALSE;
    }
    else {
        return TRUE;
    }
}

char* removeWhitespace(char input[]) {
    char output[MAX_CHARS_IN_NAME];
    removeWhitespaceRecursive(input, output, 0, 0); // Call the recursive function
    return strdup(output);
}

void removeWhitespaceRecursive(char input[], char output[], int index, int outIndex) {

    // Base case: end of input string
    if (input[index] == '\0') {
        output[outIndex] = '\0';  // Null-terminate the output string
        return;
    }

    // If the current character is not whitespace, add it to the output
    if (isWhitespace(input[index]) == FALSE) {
        output[outIndex] = input[index];
        removeWhitespaceRecursive(input, output, index + 1, outIndex + 1);
    } else {
        // If the current character is whitespace, skip it
        removeWhitespaceRecursive(input, output, index + 1, outIndex);
    }
}

int isWhitespace(char c) {
    return (c == ' ' || c == '\t' || c == '\n' || c == '\r');
}

void greetUser(char *name) {
	printf("Hello, %s!\n", name);
}
