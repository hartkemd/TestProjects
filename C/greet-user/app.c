#include <stdio.h>
#include <string.h>
#include <stdbool.h>

const int maxCharsInName = 20;

void getNameFromUser(char *name);
void removeNewlineChar(char input[]);
void greetUser(char name[]);
bool inputTooLong(char input[], int maxLength);

int main() {
	char name[maxCharsInName];

	getNameFromUser(name);
	greetUser(name);

	return 0;
}

void getNameFromUser(char *name) {
	int len = 0;
	char input[50];
	while(len == 0 || len >= maxCharsInName) {
		printf("Please enter your first name: ");
		fgets(input, sizeof(input), stdin);
		removeNewlineChar(input);
		len = strlen(input);

		if (len == 0)
            printf("Name cannot be empty. Please try again.\n");

        if (inputTooLong(input, maxCharsInName) == true) {
            printf("The maximum characters allowed for a name is %d. Please try again.\n", maxCharsInName);
        }
	}

	strcpy(name, input);
}

void removeNewlineChar(char input[]) {
	// Replace newline character at end of string with null
	size_t len = strlen(input);
	if (len > 0 && input[len - 1] == '\n') {
		input[len - 1] = '\0';
	}
}

bool inputTooLong(char input[], int maxLength) {
	size_t len = strlen(input);
	if (len > maxLength) return true;
	else return false;
}

void greetUser(char *name) {
	size_t len = strlen(name);
	printf("Hello, %s!\n", name);
}
