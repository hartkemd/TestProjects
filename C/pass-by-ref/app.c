#include <stdio.h>

void changeNum(int *value);
void printValOfInt(int var);

int main()
{
    int num = 5;

    printValOfInt(num);
    changeNum(&num);
    printValOfInt(num);

    return 0;
}

void changeNum(int *value) {
    *value = 10;
}

void printValOfInt(int var) {
    printf("The value of num is: %d\n", var);
}
