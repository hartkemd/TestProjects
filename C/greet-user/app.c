#include <stdio.h>
#include <string.h>
#include <stdbool.h>
#include <ctype.h>

const int maxCharsInName = 20;

void getNameFromUser(char *name);
void removeNewlineChar(char input[], size_t len);
void removeWhitespace(char *input);
bool inputTooLong(char input[], size_t len, int maxLength);
void greetUser(char name[]);

int main() {
	char name[maxCharsInName];

	getNameFromUser(name);
	greetUser(name);

	return 0;
}

void getNameFromUser(char *name) {
	size_t len = 0;
	char input[50];
	while(len == 0 || len >= maxCharsInName) {
		printf("Please enter your first name: ");
		fgets(input, sizeof(input), stdin);
		len = strlen(input);
		removeNewlineChar(input, len);
        removeWhitespace(input);
		len = strlen(input);

		if (len == 0)
            printf("Name cannot be empty. Please try again.\n");
        else if (inputTooLong(input, len, maxCharsInName) == true)
            printf("The maximum characters allowed for a name is %d. Please try again.\n", maxCharsInName);
	}

	strcpy(name, input);
}

void removeNewlineChar(char input[], size_t len) {
	// Replace newline character at end of string with null
	if (len > 0 && input[len - 1] == '\n') {
		input[len - 1] = '\0';
	}
}

void removeWhitespace(char *input) {

    // Base case: If the string is empty, return
    if (*input == '\0') {
        return;
    }

    // If the current character is a whitespace character, remove it
    if ((isspace(*input) != 0)) {
        // Shift all characters to the left
        char *temp = input;
        while (*temp != '\0') {
            *temp = *(temp + 1);
            temp++;
        }

        // Call the function recursively on the modified string
        removeWhitespace(input);
    } else {
        // Move to the next character in the string
        removeWhitespace(input + 1);
    }
}

bool inputTooLong(char input[], size_t len, int maxLength) {
	if (len > maxLength) return true;
	else return false;
}

void greetUser(char *name) {
	printf("Hello, %s!\n", name);
}
