
#include <stdio.h>
#include <stdlib.h>

int* removeDuplicates(int arr[], int size, int* newSize) {
    // Check for empty array
    if (size == 0) {
        *newSize = 0;
        return NULL;
    }

    // Sort the array (optional, but can simplify duplicate removal)
    for (int i = 0; i < size - 1; i++) {
        for (int j = i + 1; j < size; j++) {
            if (arr[i] > arr[j]) {
                // Swap elements if they are in the wrong order
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    // Remove duplicates
    int* result = (int*)malloc(size * sizeof(int));
    int index = 0;

    for (int i = 0; i < size; i++) {
        // Check if the current element is different from the next one
        if (i == size - 1 || arr[i] != arr[i + 1]) {
            result[index++] = arr[i];
        }
    }

    // Set the new size
    *newSize = index;

    return result;
}

void printArray(int array[], int size) {

    printf("[");
    for (int i = 0; i < size; i++) {
        if (i != size - 1) {
            printf("%d, ", array[i]);
        }
        else {
            printf("%d", array[i]);
        }
    }
    printf("]\n");

}

int main() {
    int array[10] = {};
    int size = sizeof(array) / sizeof(array[0]);
    int newSize;

    printArray(array, size);
    int* result = removeDuplicates(array, size, &newSize);
    printf("Array after duplicates removed:\n");
    printArray(result, newSize);

    int array2[10] = {1, 1};
    size = sizeof(array2) / sizeof(array2[0]);
    printArray(array2, size);
    result = removeDuplicates(array2, size, &newSize);
    printf("Array after duplicates removed:\n");
    printArray(result, newSize);

    // Free the dynamically allocated memory
    free(result);

    return 0;
}
